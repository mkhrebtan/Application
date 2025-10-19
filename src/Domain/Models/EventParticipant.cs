using Domain.Abstraction;

namespace Domain.Models;

public class EventParticipant(
    Guid eventId,
    Guid? userId = null,
    Guid? visitorId = null,
    string visitorFirstName = "",
    string visitorLastName = "",
    string visitorEmail = "") : Model
{
    public Guid EventId { get; private set; } = eventId;

    public Guid? UserId { get; private set; } = userId;

    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

    public Guid? VisitorId { get; set; } = visitorId;

    public string VisitorFirstName { get; set; } = visitorFirstName;

    public string VisitorLastName { get; set; } = visitorLastName;

    public string VisitorEmail { get; set; } = visitorEmail;

    public Event? Event { get; set; }

    public User? User { get; set; }
}