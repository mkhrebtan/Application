using Domain.Abstraction;
using Domain.Shared.ErrorHandling;

namespace Domain.Models;

public class Event : Model
{
    public const int MaxTitleLength = 100;
    public const int MaxDescriptionLength = 500;
    public const int MaxLocationNameLength = 100;

    private Event(
        Guid organizerId,
        string title,
        string description,
        DateTime date,
        string location,
        int? capacity = null)
    {
        Title = title;
        Description = description;
        Date = date;
        Location = location;
        Capacity = capacity;
        OrganizerId = organizerId;
    }

    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime Date { get; set; }

    public string Location { get; set; }

    public int? Capacity { get; set; }

    public Guid OrganizerId { get; set; }

    public static Result<Event> Create(
        Guid organizerId,
        string title,
        string description,
        DateTime date,
        string location,
        int? capacity = null)
    {
        var validationResult = Validate(title, description, date, location, capacity);
        if (validationResult.IsFailure)
        {
            return Result<Event>.Failure(validationResult.Error);
        }

        var eventInstance = new Event(organizerId, title, description, date, location, capacity);
        return Result<Event>.Success(eventInstance);
    }

    private static Result Validate(string title, string description, DateTime date, string location, int? capacity)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            return Result.Failure(Error.Problem(
                "Event.Title.Empty",
                "Title cannot be empty."));
        }

        if (title.Length > MaxTitleLength)
        {
            return Result.Failure(Error.Problem(
                "Event.Title.TooLong",
                $"Title cannot exceed {MaxTitleLength} characters."));
        }

        if (description.Length > MaxDescriptionLength)
        {
            return Result.Failure(Error.Problem(
                "Event.Description.TooLong",
                $"Description cannot exceed {MaxDescriptionLength} characters."));
        }

        if (date < DateTime.UtcNow)
        {
            return Result.Failure(Error.Problem(
                "Event.Date.Past",
                "Event date cannot be in the past."));
        }

        if (string.IsNullOrWhiteSpace(location))
        {
            return Result.Failure(Error.Problem(
                "Event.Location.Empty",
                "Location cannot be empty."));
        }

        if (location.Length > MaxLocationNameLength)
        {
            return Result.Failure(Error.Problem(
                "Event.Location.TooLong",
                $"Location cannot exceed {MaxLocationNameLength} characters."));
        }

        if (capacity is <= 0)
        {
            return Result.Failure(Error.Problem(
                "Event.Capacity.Invalid",
                "Capacity must be a positive number."));
        }

        return Result.Success();
    }
}