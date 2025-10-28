using Application.Queries.Tags.GetTags;

namespace Application.ReadServices;

public interface ITagsReadService
{
    Task<IEnumerable<TagDto>> GetTagsAsync(CancellationToken cancellationToken = default);
}