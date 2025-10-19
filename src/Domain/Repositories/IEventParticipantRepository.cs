using Domain.Models;

namespace Domain.Repositories;

public interface IEventParticipantRepository : IRepository<EventParticipant>
{
    Task<IEnumerable<EventParticipant>> GetByEventIdAsync(Guid eventId);

    Task<IEnumerable<EventParticipant>> GetByUserIdAsync(Guid userId);

    Task<bool> IsUserParticipantInEventAsync(Guid userId, Guid eventId);

    Task<int> GetEventParticipantCountAsync(Guid eventId);
}