namespace Application.Assistant;

public interface IAiAssistant
{
    Task<string> GetResponseAsync(Prompt prompt, CancellationToken cancellationToken);
}