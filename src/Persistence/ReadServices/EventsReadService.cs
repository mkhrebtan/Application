using Application.Queries;
using Application.Queries.GetEventsList;
using Application.ReadServices;

namespace Persistence.ReadServices;

public class EventsReadService(ApplicationDbContext dbContext, IPagedList<EventListingDto> pagedList)
    : IEventsReadService
{
    public async Task<IPagedList<EventListingDto>> GetEventsAsync(
        Guid requesterId,
        string? searchTerm,
        bool? today,
        bool? weekend,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = dbContext.Events.Where(e => e.Date >= DateTime.Today.ToUniversalTime() && e.IsPublic).AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            query = query.Where(e =>
                e.Title.Contains(searchTerm) ||
                e.Description.Contains(searchTerm) ||
                e.Location.Contains(searchTerm));
        }

        if (today == true)
        {
            var todayDate = DateTime.UtcNow.Date;
            query = query.Where(e => e.Date.Date == todayDate);
        }
        else if (weekend == true)
        {
            query = query.Where(e =>
                e.Date.DayOfWeek == DayOfWeek.Saturday ||
                e.Date.DayOfWeek == DayOfWeek.Sunday);
        }

        var eventListingDtos = query.Select(e => new EventListingDto(
            e.Id,
            e.Title,
            e.Description,
            e.Date,
            e.Location,
            e.Capacity,
            e.EventParticipants.Count,
            new RequesterStatusDto(
                e.EventParticipants.Any(ep => ep.UserId == requesterId || ep.VisitorId == requesterId),
                e.OrganizerId == requesterId)));

        return await pagedList.Create(eventListingDtos, pageNumber, pageSize);
    }
}