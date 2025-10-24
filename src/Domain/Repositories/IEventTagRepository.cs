using Domain.Models;

namespace Domain.Repositories;

public interface IEventTagRepository : IRepository<EventTag>
{
    void AddRange(IEnumerable<EventTag> eventTags);
}