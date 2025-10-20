using Application.Authentication;
using Application.Mediator;
using Application.ReadServices;
using Domain.Shared.ErrorHandling;

namespace Application.Queries.GetEventsList;

internal sealed class EventsListQueryHandler(IEventsReadService eventsReadService, IUserContext userContext)
    : IQueryHandler<GetEventsListQuery, EventsListQueryResponse>
{
    public async Task<Result<EventsListQueryResponse>> Handle(
        GetEventsListQuery query,
        CancellationToken cancellationToken = default)
    {
        var requesterId = userContext.UserId ?? query.VisitorId;
        if (requesterId is null)
        {
            return Result<EventsListQueryResponse>.Failure(Error.Validation(
                "GetEventsList.InvalidRequester",
                "Either an authenticated user or a visitor ID must be provided."));
        }

        var pagedEvents = await eventsReadService.GetEventsAsync(
            requesterId.Value,
            query.SearchTerm,
            query.Today,
            query.Weekend,
            query.PageNumber,
            query.PageSize,
            cancellationToken);
        return Result<EventsListQueryResponse>.Success(new EventsListQueryResponse(pagedEvents));
    }
}