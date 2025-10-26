using Domain.Abstraction;

namespace Domain.Models;

public class Tag : Model
{
    public Tag(string name)
    {
        Name = name;
        NormalizedName = NormalizeName(name);
    }

    public string Name { get; private set; }

    public string NormalizedName { get; private set; }

    public static string NormalizeName(string name)
    {
        return name.Trim().ToLowerInvariant().Replace(" ", string.Empty);
    }
}