using Application.Mediator;
using Application.ReadServices;
using Domain.Shared.ErrorHandling;

namespace Application.Queries.Events.GetEventParticipants;

internal sealed class GetEventParticipantsQueryHandler(IEventsReadService eventsReadService)
    : IQueryHandler<GetEventParticipantsQuery, GetEventParticipantsQueryResponse>
{
    public async Task<Result<GetEventParticipantsQueryResponse>> Handle(
        GetEventParticipantsQuery query,
        CancellationToken cancellationToken = default)
    {
        var participants = await eventsReadService.GetEventParticipantsAsync(
            query.EventId,
            cancellationToken);
        return Result<GetEventParticipantsQueryResponse>.Success(new GetEventParticipantsQueryResponse(participants));
    }
}