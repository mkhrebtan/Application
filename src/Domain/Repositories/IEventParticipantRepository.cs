using Domain.Models;

namespace Domain.Repositories;

public interface IEventParticipantRepository : IRepository<EventParticipant>
{
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

    Task MergeVisitorParticipantsAsync(
        Guid visitorId,
        Guid userId,
        string userEmail,
        CancellationToken cancellationToken = default);
}