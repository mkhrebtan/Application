namespace Application.Assistant;

public record PromptEvent(
    Guid Id,
    string Title,
    DateTime Date,
    string Location,
    Guid OrganizerId,
    bool IsPublic,
    IEnumerable<string> Tags,
    IEnumerable<PromptEventParticipant> Participants);