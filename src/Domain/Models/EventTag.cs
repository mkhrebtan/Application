using Domain.Abstraction;

namespace Domain.Models;

public class EventTag : Model
{
    public EventTag(Guid eventId, Guid tagId)
    {
        EventId = eventId;
        TagId = tagId;
    }

    public Guid EventId { get; private set; }

    public Guid TagId { get; private set; }
}