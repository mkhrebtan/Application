namespace Application.Assistant;

public record Prompt(
    PromptContextData ContextData,
    string Query);