namespace Application.Queries.Events.GetUserEvents;

public record UserEventDto(
    Guid Id,
    string Title,
    DateTime Date,
    string Location,
    bool IsUserOrganizer);