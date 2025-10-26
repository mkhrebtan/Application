using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class TagRepository(ApplicationDbContext context) : GenericRepository<Tag>(context), ITagRepository
{
    public async Task<bool> TagIdsExistAsync(ICollection<Guid> tagIds, CancellationToken cancellationToken = default)
    {
        return await _dbSet.Where(tag => tagIds.Contains(tag.Id))
            .CountAsync(cancellationToken) == tagIds.Count;
    }

    public async Task<List<Tag>> GetTagsByNamesAsync(
        IEnumerable<string> normalizedTagNames,
        CancellationToken cancellationToken = default)
    {
        return await _dbSet.Where(tag => normalizedTagNames.Contains(tag.NormalizedName))
            .ToListAsync(cancellationToken);
    }
}