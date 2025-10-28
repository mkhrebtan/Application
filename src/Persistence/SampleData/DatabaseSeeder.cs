using Domain.Models;

namespace Persistence.SampleData;

internal static class DatabaseSeeder
{
    private const string _preHashedPassword = "$2a$11$V2cYAlIQUgz1cAHT9elmteBzF.zj.Zc4pIIjRBHojluqcJKLMbbue";

    private static readonly Guid[] VisitorIds =
    [
        Guid.Parse("10000000-0000-0000-0000-000000000001"),
        Guid.Parse("10000000-0000-0000-0000-000000000002"),
        Guid.Parse("10000000-0000-0000-0000-000000000003"),
        Guid.Parse("10000000-0000-0000-0000-000000000004"),
        Guid.Parse("10000000-0000-0000-0000-000000000005"),
        Guid.Parse("10000000-0000-0000-0000-000000000006"),
        Guid.Parse("10000000-0000-0000-0000-000000000007"),
        Guid.Parse("10000000-0000-0000-0000-000000000008"),
        Guid.Parse("10000000-0000-0000-0000-000000000009"),
        Guid.Parse("10000000-0000-0000-0000-000000000010"),
        Guid.Parse("10000000-0000-0000-0000-000000000011"),
        Guid.Parse("10000000-0000-0000-0000-000000000012"),
    ];

    internal static readonly User[] Users =
    {
        User.Create(
            "John",
            "Doe",
            "john.doe@example.com",
            _preHashedPassword).Value,
        User.Create(
            "Jane",
            "Smith",
            "jane.smith@example.com",
            _preHashedPassword).Value,
        User.Create(
            "Alice",
            "Johnson",
            "alice.johnson@example.com",
            _preHashedPassword).Value,
    };

    internal static readonly Tag[] Tags =
    [
        new("Technology"),
        new("Art"),
        new("Health"),
        new("Education"),
        new("Networking"),
        new("Music"),
        new("Sports"),
        new("Food & Drink"),
        new("Business"),
        new("Travel"),
    ];

    internal static Event[] Events(User[] users)
    {
        return
        [
            // Future events
            Event.Create(
                users[0].Id,
                "Community Meetup",
                "A meetup for community members.",
                DateTime.UtcNow.AddDays(1),
                "Community Center",
                true).Value,
            Event.Create(
                users[1].Id,
                "Tech Conference",
                "Annual technology conference.",
                DateTime.UtcNow.AddDays(7),
                "Convention Hall",
                true,
                50).Value,
            Event.Create(
                users[2].Id,
                "Art Workshop",
                "A workshop for art enthusiasts.",
                DateTime.UtcNow.AddDays(14),
                "Art Studio",
                true).Value,
            Event.Create(
                users[0].Id,
                "Private Dinner Party",
                "An exclusive dinner party for close friends.",
                DateTime.UtcNow.AddDays(3),
                "Home",
                false).Value,
            Event.Create(
                users[1].Id,
                "Board Game Night",
                "Private board game session.",
                DateTime.UtcNow.AddDays(5),
                "Game Cafe",
                false,
                8).Value,
            Event.Create(
                users[2].Id,
                "Yoga Class",
                "Morning yoga session for all levels.",
                DateTime.UtcNow.AddDays(2),
                "Wellness Center",
                true,
                20).Value,
            Event.Create(
                users[0].Id,
                "Family Reunion",
                "Annual family gathering.",
                DateTime.UtcNow.AddDays(30),
                "Family Home",
                false,
                25).Value,
            Event.Create(
                users[1].Id,
                "City Marathon",
                "Annual city-wide marathon event.",
                DateTime.UtcNow.AddDays(60),
                "City Streets",
                true).Value,
        ];
    }

    internal static EventParticipant[] EventParticipants(Event[] events, User[] users)
    {
        return
        [
            new EventParticipant(events[0].Id, users[1].Id),
            new EventParticipant(events[0].Id, users[2].Id),
            new EventParticipant(events[0].Id, visitorId: VisitorIds[0], visitorFirstName: "Michael",
                visitorLastName: "Brown", visitorEmail: "michael.brown@example.com"),
            new EventParticipant(events[0].Id, visitorId: VisitorIds[1], visitorFirstName: "Sarah",
                visitorLastName: "Wilson", visitorEmail: "sarah.wilson@example.com"),
            new EventParticipant(events[1].Id, users[0].Id),
            new EventParticipant(events[1].Id, users[2].Id),
            new EventParticipant(events[1].Id, visitorId: VisitorIds[2], visitorFirstName: "David",
                visitorLastName: "Martinez", visitorEmail: "david.martinez@example.com"),
            new EventParticipant(events[1].Id, visitorId: VisitorIds[3], visitorFirstName: "Emma",
                visitorLastName: "Garcia", visitorEmail: "emma.garcia@example.com"),
            new EventParticipant(events[1].Id, visitorId: VisitorIds[4], visitorFirstName: "James",
                visitorLastName: "Anderson", visitorEmail: "james.anderson@example.com"),
            new EventParticipant(events[2].Id, users[0].Id),
            new EventParticipant(events[2].Id, visitorId: VisitorIds[1], visitorFirstName: "Sarah",
                visitorLastName: "Wilson", visitorEmail: "sarah.wilson@example.com"),
            new EventParticipant(events[3].Id, users[1].Id),
            new EventParticipant(events[3].Id, users[2].Id),
            new EventParticipant(events[4].Id, users[0].Id),
            new EventParticipant(events[4].Id, users[2].Id),
            new EventParticipant(events[4].Id, visitorId: VisitorIds[5], visitorFirstName: "Liam",
                visitorLastName: "Thomas", visitorEmail: "liam.thomas@example.com"),
            new EventParticipant(events[4].Id, visitorId: VisitorIds[6], visitorFirstName: "Sophia",
                visitorLastName: "Jackson", visitorEmail: "sophia.jackson@example.com"),
            new EventParticipant(events[4].Id, visitorId: VisitorIds[7], visitorFirstName: "Noah",
                visitorLastName: "White", visitorEmail: "noah.white@example.com"),
            new EventParticipant(events[5].Id, users[0].Id),
            new EventParticipant(events[5].Id, users[1].Id),
            new EventParticipant(events[5].Id, visitorId: VisitorIds[3], visitorFirstName: "Emma",
                visitorLastName: "Garcia", visitorEmail: "emma.garcia@example.com"),
            new EventParticipant(events[5].Id, visitorId: VisitorIds[8], visitorFirstName: "William",
                visitorLastName: "Martin", visitorEmail: "william.martin@example.com"),
            new EventParticipant(events[6].Id, users[1].Id),
            new EventParticipant(events[6].Id, users[2].Id),
            new EventParticipant(events[6].Id, visitorId: VisitorIds[9], visitorFirstName: "Isabella",
                visitorLastName: "Thompson", visitorEmail: "isabella.thompson@example.com"),
            new EventParticipant(events[7].Id, users[0].Id),
            new EventParticipant(events[7].Id, users[2].Id),
            new EventParticipant(events[7].Id, visitorId: VisitorIds[0], visitorFirstName: "Michael",
                visitorLastName: "Brown", visitorEmail: "michael.brown@example.com"),
            new EventParticipant(events[7].Id, visitorId: VisitorIds[10], visitorFirstName: "Charlotte",
                visitorLastName: "Lee", visitorEmail: "charlotte.lee@example.com"),
            new EventParticipant(events[7].Id, visitorId: VisitorIds[11], visitorFirstName: "Ethan",
                visitorLastName: "Walker", visitorEmail: "ethan.walker@example.com"),
        ];
    }

    internal static EventTag[] EventTags(Event[] events, Tag[] tags)
    {
        return
        [
            new EventTag(events[0].Id, tags[4].Id),
            new EventTag(events[0].Id, tags[8].Id),
            new EventTag(events[1].Id, tags[0].Id),
            new EventTag(events[1].Id, tags[8].Id),
            new EventTag(events[1].Id, tags[4].Id),
            new EventTag(events[2].Id, tags[1].Id),
            new EventTag(events[3].Id, tags[8].Id),
            new EventTag(events[3].Id, tags[7].Id),
            new EventTag(events[3].Id, tags[4].Id),
            new EventTag(events[4].Id, tags[3].Id),
            new EventTag(events[4].Id, tags[4].Id),
            new EventTag(events[5].Id, tags[2].Id),
            new EventTag(events[5].Id, tags[3].Id),
            new EventTag(events[6].Id, tags[9].Id),
            new EventTag(events[6].Id, tags[7].Id),
            new EventTag(events[6].Id, tags[4].Id),
            new EventTag(events[7].Id, tags[6].Id),
        ];
    }
}