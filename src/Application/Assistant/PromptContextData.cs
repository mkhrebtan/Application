namespace Application.Assistant;

public record PromptContextData(
    DateTime CurrentDate,
    Guid UserId,
    string UserFirstName,
    IEnumerable<PromptEvent> Events);