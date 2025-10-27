namespace Application.Assistant;

public record PromptEventParticipant(
    Guid Id,
    string FirstName,
    string LastName);