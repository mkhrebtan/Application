using Domain.Abstraction;

namespace Domain.Models;

public class Tag : Model
{
    public Tag(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
}