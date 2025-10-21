using Application.Authentication;
using Application.Mediator;
using Application.ReadServices;
using Domain.Shared.ErrorHandling;

namespace Application.Queries.Events.GetUserEvents;

public record GetUserEventsQuery : IQuery<GetUserEventsQueryResponse>;

internal sealed class GetUserEventsQueryHandler(
    IEventsReadService eventsReadService,
    IUserContext userContext)
    : IQueryHandler<GetUserEventsQuery, GetUserEventsQueryResponse>
{
    public async Task<Result<GetUserEventsQueryResponse>> Handle(
        GetUserEventsQuery query,
        CancellationToken cancellationToken = default)
    {
        var userId = userContext.UserId;
        if (userId is null || userId == Guid.Empty)
        {
            return Result<GetUserEventsQueryResponse>.Failure(Error.Problem(
                "GetUserEvents.Unauthenticated",
                "User must be authenticated to retrieve their events."));
        }

        var userEvents = await eventsReadService.GetUserEventsListAsync(
            userId.Value,
            cancellationToken);
        return Result<GetUserEventsQueryResponse>.Success(new GetUserEventsQueryResponse(userEvents));
    }
}