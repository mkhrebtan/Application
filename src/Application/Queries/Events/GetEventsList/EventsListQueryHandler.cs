using Application.Authentication;
using Application.Mediator;
using Application.ReadServices;
using Domain.Shared.ErrorHandling;

namespace Application.Queries.Events.GetEventsList;

internal sealed class EventsListQueryHandler(IEventsReadService eventsReadService, IUserContext userContext)
    : IQueryHandler<GetEventsListQuery, EventsListQueryResponse>
{
    public async Task<Result<EventsListQueryResponse>> Handle(
        GetEventsListQuery query,
        CancellationToken cancellationToken = default)
    {
        var userId = userContext.UserId;
        var visitorId = query.VisitorId;

        if ((userId is null || userId.Equals(Guid.Empty)) && visitorId is null)
        {
            return Result<EventsListQueryResponse>.Failure(Error.Validation(
                "GetEventsList.InvalidRequester",
                "Either an authenticated user or a visitor ID must be provided."));
        }

        var pagedEvents = await eventsReadService.GetEventsAsync(
            userId,
            visitorId,
            query.SearchTerm,
            query.Today,
            query.Weekend,
            query.TagIds,
            query.PageNumber,
            query.PageSize,
            cancellationToken);
        return Result<EventsListQueryResponse>.Success(new EventsListQueryResponse(pagedEvents));
    }
}