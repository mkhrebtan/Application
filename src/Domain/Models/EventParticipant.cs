using Domain.Abstraction;

namespace Domain.Models;

public class EventParticipant(Guid eventId, Guid userId) : Model
{
    public Guid EventId { get; private set; } = eventId;

    public Guid UserId { get; private set; } = userId;

    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

    public Event? Event { get; set; }

    public User? User { get; set; }
}