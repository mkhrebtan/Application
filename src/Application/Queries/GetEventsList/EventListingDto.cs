namespace Application.Queries.GetEventsList;

public record EventListingDto(
    Guid Id,
    string Title,
    string Description,
    DateTime Date,
    string Location,
    int? Capacity,
    int ParticipantsCount,
    RequesterStatusDto RequesterStatus);