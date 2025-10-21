using Application.Mediator;

namespace Application.Queries.Events.GetEventParticipants;

public record GetEventParticipantsQuery(Guid EventId) : IQuery<GetEventParticipantsQueryResponse>;