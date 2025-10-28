using Application.Queries.Tags.GetTags;
using Application.ReadServices;
using Microsoft.EntityFrameworkCore;

namespace Persistence.ReadServices;

public class TagReadService(ApplicationDbContext dbContext) : ITagsReadService
{
    public async Task<IEnumerable<TagDto>> GetTagsAsync(CancellationToken cancellationToken = default)
    {
        return await dbContext.Tags.Select(t => new TagDto(t.Id, t.Name)).ToArrayAsync(cancellationToken);
    }
}