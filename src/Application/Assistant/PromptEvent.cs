namespace Application.Assistant;

public record PromptEvent(
    Guid Id,
    string Title,
    DateTime Date,
    string Location,
    Guid OrganizerId,
    IEnumerable<string> Tags,
    IEnumerable<PromptEventParticipant> Participants);