using Domain.Abstraction;

namespace Domain.Models;

public class EventParticipant(Guid eventId, Guid userId) : Model
{
    public Guid EventId { get; set; } = eventId;

    public Guid UserId { get; set; } = userId;
}