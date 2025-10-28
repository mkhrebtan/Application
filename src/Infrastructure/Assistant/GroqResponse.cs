using System.Text.Json.Serialization;

namespace Infrastructure.Assistant;

internal record GroqResponse(
    string Id,
    string Object,
    long Created,
    string Model,
    GroqChoice[]? Choices,
    GroqUsage? Usage,
    [property: JsonPropertyName("usage_breakdown")] object? UsageBreakdown,
    [property: JsonPropertyName("system_fingerprint")] string SystemFingerprint,
    [property: JsonPropertyName("x_groq")] GroqMetadata? XGroq,
    [property: JsonPropertyName("service_tier")] string ServiceTier
);