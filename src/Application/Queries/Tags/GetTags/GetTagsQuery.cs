using Application.Mediator;
using Application.ReadServices;
using Domain.Shared.ErrorHandling;

namespace Application.Queries.Tags.GetTags;

public record GetTagsQuery : IQuery<GetTagsQueryResponse>;

internal sealed class GetTagsQueryHandler(ITagsReadService tagsReadService)
    : IQueryHandler<GetTagsQuery, GetTagsQueryResponse>
{
    public async Task<Result<GetTagsQueryResponse>> Handle(GetTagsQuery query,
        CancellationToken cancellationToken = default)
    {
        var tags = await tagsReadService.GetTagsAsync(cancellationToken);
        return Result<GetTagsQueryResponse>.Success(new GetTagsQueryResponse(tags));
    }
}