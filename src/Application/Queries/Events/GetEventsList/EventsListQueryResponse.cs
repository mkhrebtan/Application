namespace Application.Queries.Events.GetEventsList;

public record EventsListQueryResponse(IPagedList<EventListingDto> Events);