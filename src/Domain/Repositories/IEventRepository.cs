using Domain.Models;

namespace Domain.Repositories;

public interface IEventRepository : IRepository<Event>
{
    IQueryable<Event> GetEventsQueryable();

    Task<IEnumerable<Event>> MaterializeEventsQueryAsync(IQueryable<Event> query);
}