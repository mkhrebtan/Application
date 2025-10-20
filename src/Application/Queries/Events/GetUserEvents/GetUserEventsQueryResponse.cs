namespace Application.Queries.Events.GetUserEvents;

public record GetUserEventsQueryResponse(
    List<UserEventDto> Events);