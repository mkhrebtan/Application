using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class EventRepository(ApplicationDbContext context) : GenericRepository<Event>(context), IEventRepository
{
    public IQueryable<Event> GetEventsQueryable()
    {
        return _dbSet.AsQueryable();
    }

    public async Task<IEnumerable<Event>> MaterializeEventsQueryAsync(
        IQueryable<Event> query,
        CancellationToken cancellationToken = default)
    {
        return await query.ToListAsync(cancellationToken);
    }

    public async Task<Event?> GetByIdWithTagsAsync(Guid eventId, CancellationToken cancellationToken = default)
    {
        return await _dbSet.Include(e => e.EventTags)
            .FirstOrDefaultAsync(e => e.Id == eventId, cancellationToken);
    }
}