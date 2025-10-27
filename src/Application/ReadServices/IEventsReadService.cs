using Application.Assistant;
using Application.Queries;
using Application.Queries.Events.GetEvent;
using Application.Queries.Events.GetEventParticipants;
using Application.Queries.Events.GetEventsList;
using Application.Queries.Events.GetUserEvents;

namespace Application.ReadServices;

public interface IEventsReadService
{
    Task<IPagedList<EventListingDto>> GetEventsAsync(
        Guid? userId,
        Guid? visitorId,
        string? searchTerm,
        bool? today,
        bool? weekend,
        Guid[]? tagIds,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default);

    Task<EventDetailsDto?> GetEventDetailsAsync(
        Guid eventId,
        Guid? userId,
        Guid? visitorId,
        CancellationToken cancellationToken = default);

    Task<List<UserEventDto>> GetUserEventsListAsync(Guid userId, CancellationToken cancellationToken = default);

    Task<List<EventParticipantDto>> GetEventParticipantsAsync(
        Guid eventId,
        CancellationToken cancellationToken = default);

    Task<IEnumerable<PromptEvent>> GetEventsForAssistantAsync(CancellationToken cancellationToken = default);
}