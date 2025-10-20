namespace Application.Queries.GetEventsList;

public record EventsListQueryResponse(IPagedList<EventListingDto> Events);