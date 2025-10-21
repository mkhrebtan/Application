using Application.Mediator;

namespace Application.Queries.Events.GetEvent;

public record GetEventQuery(
    Guid EventId,
    Guid? VisitorId) : IQuery<GetEventQueryResponse>;