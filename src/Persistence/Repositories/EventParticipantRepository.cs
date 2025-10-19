using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class EventParticipantRepository(ApplicationDbContext context)
    : GenericRepository<EventParticipant>(context), IEventParticipantRepository
{
    public async Task<IEnumerable<EventParticipant>> GetByEventIdAsync(
        Guid eventId,
        CancellationToken cancellationToken = default)
    {
        return await _dbSet.Where(ep => ep.EventId == eventId).Include(ep => ep.User).ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<EventParticipant>> GetByUserIdAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        return await _dbSet.Where(ep => ep.UserId == userId).Include(ep => ep.Event).ToListAsync(cancellationToken);
    }

    public async Task<bool> IsUserParticipantInEventAsync(
        Guid userId,
        Guid eventId,
        CancellationToken cancellationToken = default)
    {
        return await _dbSet.AnyAsync(ep => ep.UserId == userId && ep.EventId == eventId, cancellationToken);
    }

    public async Task<int> GetEventParticipantCountAsync(Guid eventId, CancellationToken cancellationToken = default)
    {
        return await _dbSet.CountAsync(ep => ep.EventId == eventId, cancellationToken);
    }
}