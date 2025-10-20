using Application.Authentication;
using Application.Mediator;
using Application.ReadServices;
using Domain.Shared.ErrorHandling;

namespace Application.Queries.Events.GetEvent;

internal sealed class GetEventQueryHandler(
    IEventsReadService eventsReadService,
    IUserContext userContext)
    : IQueryHandler<GetEventQuery, GetEventQueryResponse>
{
    public async Task<Result<GetEventQueryResponse>> Handle(
        GetEventQuery query,
        CancellationToken cancellationToken = default)
    {
        var userId = userContext.UserId;
        var visitorId = query.VisitorId;

        if ((userId is null || userId.Equals(Guid.Empty)) && visitorId is null)
        {
            return Result<GetEventQueryResponse>.Failure(Error.Validation(
                "GetEvent.InvalidRequester",
                "Either an authenticated user or a visitor ID must be provided."));
        }

        var eventDetails = await eventsReadService.GetEventDetailsAsync(
            query.EventId,
            userId,
            visitorId,
            cancellationToken);
        if (eventDetails is null)
        {
            return Result<GetEventQueryResponse>.Failure(Error.NotFound(
                "GetEvent.EventNotFound",
                "The requested event was not found."));
        }

        return Result<GetEventQueryResponse>.Success(new GetEventQueryResponse(eventDetails));
    }
}