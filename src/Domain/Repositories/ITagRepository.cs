using Domain.Models;

namespace Domain.Repositories;

public interface ITagRepository : IRepository<Tag>
{
    Task<bool> TagIdsExistAsync(ICollection<Guid> tagIds, CancellationToken cancellationToken = default);
}