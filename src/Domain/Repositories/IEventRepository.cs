using Domain.Models;

namespace Domain.Repositories;

public interface IEventRepository : IRepository<Event>
{
    IQueryable<Event> GetEventsQueryable();

    Task<IEnumerable<Event>> MaterializeEventsQueryAsync(IQueryable<Event> query,
        CancellationToken cancellationToken = default);

    Task<Event?> GetByIdWithTagsAsync(Guid eventId, CancellationToken cancellationToken = default);
}