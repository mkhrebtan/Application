using Application.Queries;
using Application.Queries.GetEventsList;

namespace Application.ReadServices;

public interface IEventsReadService
{
    Task<IPagedList<EventListingDto>> GetEventsAsync(
        Guid requesterId,
        string? searchTerm,
        bool? today,
        bool? weekend,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default);
}