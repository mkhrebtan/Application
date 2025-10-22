using Application.Queries;
using Application.Queries.Events.GetEvent;
using Application.Queries.Events.GetEventParticipants;
using Application.Queries.Events.GetEventsList;
using Application.Queries.Events.GetUserEvents;
using Application.ReadServices;
using Microsoft.EntityFrameworkCore;

namespace Persistence.ReadServices;

public class EventsReadService(ApplicationDbContext dbContext, IPagedList<EventListingDto> pagedList)
    : IEventsReadService
{
    public async Task<IPagedList<EventListingDto>> GetEventsAsync(
        Guid? userId,
        Guid? visitorId,
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
                e.EventParticipants.Any(ep =>
                    (userId.HasValue && ep.UserId == userId.Value) ||
                    (visitorId.HasValue && ep.VisitorId == visitorId.Value)),
                userId.HasValue && e.OrganizerId == userId.Value)));

        return await pagedList.Create(eventListingDtos, pageNumber, pageSize);
    }

    public Task<EventDetailsDto?> GetEventDetailsAsync(
        Guid eventId,
        Guid? userId,
        Guid? visitorId,
        CancellationToken cancellationToken = default)
    {
        var eventDetailsDto = dbContext.Events
            .Where(e => e.Id == eventId)
            .Select(e => new EventDetailsDto(
                e.Id,
                e.Title,
                e.Description,
                e.Date,
                e.Location,
                e.Capacity,
                e.EventParticipants.Count,
                e.EventParticipants.Any(ep =>
                    (userId.HasValue && ep.UserId == userId.Value) ||
                    (visitorId.HasValue && ep.VisitorId == visitorId.Value)),
                userId.HasValue && e.OrganizerId == userId.Value,
                e.IsPublic))
            .FirstOrDefaultAsync(cancellationToken);
        return eventDetailsDto;
    }

    public Task<List<UserEventDto>> GetUserEventsListAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        var userEvents = dbContext.Events
            .Where(e => e.OrganizerId == userId || e.EventParticipants.Any(ep => ep.UserId == userId))
            .Select(e => new UserEventDto(
                e.Id,
                e.Title,
                e.Date,
                e.Location,
                e.OrganizerId == userId))
            .ToListAsync(cancellationToken);
        return userEvents;
    }

    public Task<List<EventParticipantDto>> GetEventParticipantsAsync(
        Guid eventId,
        CancellationToken cancellationToken = default)
    {
        var eventParticipants = dbContext.EventParticipants
            .Where(ep => ep.EventId == eventId)
            .Select(ep => new EventParticipantDto(
                ep.User == null ? ep.VisitorFirstName : ep.User.FirstName,
                ep.User == null ? ep.VisitorLastName : ep.User.LastName,
                ep.JoinedAt))
            .ToListAsync(cancellationToken);
        return eventParticipants;
    }
}