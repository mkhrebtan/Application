using System.Net.Http.Json;
using Application.Assistant;

namespace Infrastructure.Assistant;

internal sealed class GroqAssistant(IHttpClientFactory httpClientFactory) : IAiAssistant
{
    private const string _systemPrompt =
        """
        You are an event management assistant. Answer based ONLY on the provided data.

        DATA FORMAT:
        - CURRENT_DATE: Today's date (yyyy-MM-dd)
        - USER: Current user info with ID
        - EVENTS_SUMMARY: Event counts (Total, Organizing, Attending, Upcoming, Past, ThisWeek)
        - MY_ORGANIZED_EVENTS: Events user organizes with PARTICIPANTS listed
        - ATTENDING_EVENTS: Events user attends but doesn't organize with PARTICIPANTS listed
        - PUBLIC_EVENTS: Available public events user isn't involved with PARTICIPANTS listed
        - AVAILABLE_TAGS: All tags present in events for filtering

        EVENT FORMAT: ID|Title|Date|Location|Visibility|Participants|Relationship[Tags]

        VISIBILITY: PUB (public), PVT (private)
        RELATIONSHIP: ORGANIZING, ATTENDING, AVAILABLE

        QUERY HANDLING:
        - "X events": Filter by [X] tag or similar ones
        - Date ranges: Compare Event's Date to CURRENT_DATE
        - "Upcoming/Past events": Based on CURRENT_DATE

        Be concise and specific. Do not reference the provided data in your answer.
        Try specifying only event title, date and location in your answers when you need to mention the specific event.
        If the question is unclear or unsupported, answer: “Sorry, I didn’t understand that. Please try rephrasing your question.”
        """;

    public async Task<string> GetResponseAsync(Prompt prompt, CancellationToken cancellationToken)
    {
        using var client = httpClientFactory.CreateClient("GroqCLient");

        var messageContent = BuildUserMessage(prompt);

        var requestBody = new
        {
            model = "llama-3.3-70b-versatile",
            messages = new[]
            {
                new
                {
                    role = "system",
                    content = _systemPrompt,
                },
                new
                {
                    role = "user",
                    content = messageContent,
                },
            },
        };

        var response = await client.PostAsJsonAsync("chat/completions", requestBody, cancellationToken);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadFromJsonAsync<GroqResponse>(cancellationToken);
        return responseBody?.Choices?.FirstOrDefault()?.Message?.Content ?? string.Empty;
    }

    private static string BuildUserMessage(Prompt prompt)
    {
        var context = prompt.ContextData;
        var currentDate = context.CurrentDate.ToString("yyyy-MM-dd");

        var userInfo = $"USER: {context.UserFirstName} {context.UserLastName} (ID: {context.UserId})";

        var eventsInfo = BuildEventsInfo(context.Events, context.UserId, context.CurrentDate);

        return $"""
                CURRENT_DATE: {currentDate}
                {userInfo}

                {eventsInfo}

                QUERY: {prompt.Query}
                """;
    }

    private static string BuildEventsInfo(IEnumerable<PromptEvent> events, Guid userId, DateTime currentDate)
    {
        var eventsList = events.ToList();
        if (eventsList.Count == 0)
        {
            return "EVENTS: None";
        }

        var categorizedEvents = new List<string>();

        var myEvents = eventsList.Where(e => e.OrganizerId == userId).ToList();
        var attendingEvents = eventsList.Where(e => e.OrganizerId != userId &&
                                                    e.Participants.Any(p => p.Id == userId)).ToList();
        var upcomingEvents = eventsList.Where(e => e.Date >= currentDate).ToList();
        var pastEvents = eventsList.Where(e => e.Date < currentDate).ToList();
        var thisWeekEvents = eventsList.Where(e => e.Date >= currentDate && e.Date < currentDate.AddDays(7)).ToList();

        categorizedEvents.Add(
            $"EVENTS_SUMMARY: Total={eventsList.Count}, Organizing={myEvents.Count}, Attending={attendingEvents.Count}, Upcoming={upcomingEvents.Count}, Past={pastEvents.Count}, ThisWeek={thisWeekEvents.Count}");

        if (myEvents.Count != 0)
        {
            categorizedEvents.Add("MY_ORGANIZED_EVENTS:");
            foreach (var evt in myEvents.OrderBy(e => e.Date))
            {
                categorizedEvents.Add(FormatEventLine(evt, userId));

                if (!evt.Participants.Any())
                {
                    continue;
                }

                var participants = string.Join(",", evt.Participants.Select(p => $"{p.FirstName} {p.LastName}"));
                categorizedEvents.Add($"    PARTICIPANTS: {participants}");
            }
        }

        if (attendingEvents.Count != 0)
        {
            categorizedEvents.Add("ATTENDING_EVENTS:");
            foreach (var evt in attendingEvents.OrderBy(e => e.Date))
            {
                categorizedEvents.Add(FormatEventLine(evt, userId));

                if (!evt.Participants.Any())
                {
                    continue;
                }

                var participants = string.Join(
                    ",",
                    evt.Participants.Where(p => p.Id != userId).Select(p => $"{p.FirstName} {p.LastName}"));
                categorizedEvents.Add($"    PARTICIPANTS: {participants}");
            }
        }

        var publicEvents = eventsList
            .Where(e => e.IsPublic && e.OrganizerId != userId && e.Participants.All(p => p.Id != userId)).ToList();
        if (publicEvents.Count != 0)
        {
            categorizedEvents.Add("PUBLIC_EVENTS:");
            foreach (var evt in publicEvents.OrderBy(e => e.Date))
            {
                categorizedEvents.Add(FormatEventLine(evt, userId));

                if (!evt.Participants.Any())
                {
                    continue;
                }

                var participants = string.Join(",", evt.Participants.Select(p => $"{p.FirstName} {p.LastName}"));
                categorizedEvents.Add($"    PARTICIPANTS: {participants}");
            }
        }

        var allTags = eventsList.SelectMany(e => e.Tags).Distinct().ToList();
        if (allTags.Count != 0)
        {
            categorizedEvents.Add($"AVAILABLE_TAGS: {string.Join(",", allTags)}");
        }

        return string.Join("\n", categorizedEvents);
    }

    private static string FormatEventLine(PromptEvent evt, Guid? userId = null)
    {
        var dateStr = evt.Date.ToString("yyyy-MM-dd HH:mm");
        var visibility = evt.IsPublic ? "PUB" : "PVT";
        var tags = evt.Tags.Any() ? $"[{string.Join(",", evt.Tags)}]" : string.Empty;
        var participantCount = evt.Participants.Count();

        var relationship = userId switch
        {
            null => string.Empty,
            _ when evt.OrganizerId == userId => "ORGANIZING",
            _ when evt.Participants.Any(p => p.Id == userId) => "ATTENDING",
            _ => "AVAILABLE",
        };

        return $"{evt.Id}|{evt.Title}|{dateStr}|{evt.Location}|{visibility}|P:{participantCount}|{relationship}{tags}";
    }
}