namespace Application.Queries.Tags.GetTags;

public record GetTagsQueryResponse(IEnumerable<TagDto> Tags);