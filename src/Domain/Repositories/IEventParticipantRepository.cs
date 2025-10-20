using Domain.Models;

namespace Domain.Repositories;

public interface IEventParticipantRepository : IRepository<EventParticipant>
{
    Task<IEnumerable<EventParticipant>> GetByEventIdAsync(Guid eventId, CancellationToken cancellationToken = default);

    Task<IEnumerable<EventParticipant>> GetByUserIdAsync(Guid userId, CancellationToken cancellationToken = default);

    Task<EventParticipant?> GetByUserIdAndEventIdAsync(
        Guid userId,
        Guid eventId,
        CancellationToken cancellationToken = default);

    Task<EventParticipant?> GetByVisitorIdAndEventIdAsync(
        Guid visitorId,
        Guid eventId,
        CancellationToken cancellationToken = default);

    Task<bool> IsUserParticipantInEventAsync(Guid userId, Guid eventId, CancellationToken cancellationToken = default);

    Task<bool> IsVisitorParticipantInEventAsync(
        Guid visitorId,
        Guid eventId,
        CancellationToken cancellationToken = default);

    Task<int> GetEventParticipantCountAsync(Guid eventId, CancellationToken cancellationToken = default);
}