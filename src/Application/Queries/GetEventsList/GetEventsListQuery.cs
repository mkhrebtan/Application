using Application.Mediator;

namespace Application.Queries.GetEventsList;

public record GetEventsListQuery(
    Guid? VisitorId,
    string? SearchTerm,
    bool? Today,
    bool? Weekend,
    int PageNumber,
    int PageSize) : IQuery<EventsListQueryResponse>;