using System.Text.Json.Serialization;

namespace Infrastructure.Assistant;

internal record GroqUsage(
    [property: JsonPropertyName("queue_time")] double QueueTime,
    [property: JsonPropertyName("prompt_tokens")] int PromptTokens,
    [property: JsonPropertyName("prompt_time")] double PromptTime,
    [property: JsonPropertyName("completion_tokens")] int CompletionTokens,
    [property: JsonPropertyName("completion_time")] double CompletionTime,
    [property: JsonPropertyName("total_tokens")] int TotalTokens,
    [property: JsonPropertyName("total_time")] double TotalTime
);