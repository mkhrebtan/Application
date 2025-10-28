using Domain.Models;

namespace Domain.Repositories;

public interface ITagRepository : IRepository<Tag>
{
    Task<bool> TagIdsExistAsync(ICollection<Guid> tagIds, CancellationToken cancellationToken = default);

    Task<List<Tag>> GetTagsByNamesAsync(
        IEnumerable<string> normalizedTagNames,
        CancellationToken cancellationToken = default);
}