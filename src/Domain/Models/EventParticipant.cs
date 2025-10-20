using Domain.Abstraction;

namespace Domain.Models;

public class EventParticipant(
    Guid eventId,
    Guid? userId = null,
    Guid? visitorId = null,
    string? visitorFirstName = null,
    string? visitorLastName = null,
    string? visitorEmail = null) : Model
{
    public Guid EventId { get; private set; } = eventId;

    public Guid? UserId { get; private set; } = userId;

    public DateTime JoinedAt { get; private set; } = DateTime.UtcNow;

    public Guid? VisitorId { get; private set; } = visitorId;

    public string? VisitorFirstName { get; private set; } = visitorFirstName;

    public string? VisitorLastName { get; private set; } = visitorLastName;

    public string? VisitorEmail { get; private set; } = visitorEmail;

    public Event? Event { get; set; }

    public User? User { get; set; }
}