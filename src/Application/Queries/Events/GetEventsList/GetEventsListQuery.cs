using Application.Mediator;

namespace Application.Queries.Events.GetEventsList;

public record GetEventsListQuery(
    Guid? VisitorId,
    string? SearchTerm,
    bool? Today,
    bool? Weekend,
    Guid[]? TagIds,
    int PageNumber,
    int PageSize) : IQuery<EventsListQueryResponse>;