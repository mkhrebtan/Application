using System.Text.Json.Serialization;

namespace Infrastructure.Assistant;

internal record GroqChoice(
    int Index,
    GroqMessage? Message,
    object? Logprobs,
    [property: JsonPropertyName("finish_reason")] string FinishReason
);