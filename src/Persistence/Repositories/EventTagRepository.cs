using Domain.Models;
using Domain.Repositories;

namespace Persistence.Repositories;

public class EventTagRepository(ApplicationDbContext context)
    : GenericRepository<EventTag>(context), IEventTagRepository
{
    public void AddRange(IEnumerable<EventTag> eventTags)
    {
        _dbSet.AddRange(eventTags);
    }
}