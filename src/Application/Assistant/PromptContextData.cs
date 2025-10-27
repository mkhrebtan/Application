namespace Application.Assistant;

public record PromptContextData(
    DateTime CurrentDate,
    Guid UserId,
    string UserFirstName,
    string UserLastName,
    IEnumerable<PromptEvent> Events);