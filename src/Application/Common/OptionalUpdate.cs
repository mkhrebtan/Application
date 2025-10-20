namespace Application.Common;

public record OptionalUpdate<T>(bool IsSpecified, T? Value);