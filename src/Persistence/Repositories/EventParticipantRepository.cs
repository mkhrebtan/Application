using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class EventParticipantRepository(ApplicationDbContext context)
    : GenericRepository<EventParticipant>(context), IEventParticipantRepository
{
    public async Task<EventParticipant?> GetByUserIdAndEventIdAsync(
        Guid userId,
        Guid eventId,
        CancellationToken cancellationToken = default)
    {
        return await _dbSet.FirstOrDefaultAsync(ep => ep.UserId == userId && ep.EventId == eventId, cancellationToken);
    }

    public async Task<EventParticipant?> GetByVisitorIdAndEventIdAsync(
        Guid visitorId,
        Guid eventId,
        CancellationToken cancellationToken = default)
    {
        return await _dbSet.FirstOrDefaultAsync(
            ep => ep.VisitorId == visitorId && ep.EventId == eventId,
            cancellationToken);
    }

    public async Task<bool> IsUserParticipantInEventAsync(
        Guid userId,
        Guid eventId,
        CancellationToken cancellationToken = default)
    {
        return await _dbSet.AnyAsync(ep => ep.UserId == userId && ep.EventId == eventId, cancellationToken);
    }

    public async Task<bool> IsVisitorParticipantInEventAsync(
        Guid visitorId,
        Guid eventId,
        CancellationToken cancellationToken = default)
    {
        return await _dbSet.AnyAsync(ep => ep.VisitorId == visitorId && ep.EventId == eventId, cancellationToken);
    }

    public async Task<int> GetEventParticipantCountAsync(Guid eventId, CancellationToken cancellationToken = default)
    {
        return await _dbSet.CountAsync(ep => ep.EventId == eventId, cancellationToken);
    }

    public async Task MergeVisitorParticipantsAsync(
        Guid visitorId,
        Guid userId,
        string userEmail,
        CancellationToken cancellationToken = default)
    {
        var visitorParticipants = await _dbSet.Where(ep => ep.VisitorId == visitorId || ep.VisitorEmail == userEmail)
            .ToListAsync(cancellationToken);
        foreach (var participant in visitorParticipants)
        {
            participant.AssignToUser(userId);
            Update(participant);
        }
    }

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
}