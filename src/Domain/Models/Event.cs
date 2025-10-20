using Domain.Abstraction;
using Domain.Shared.ErrorHandling;

namespace Domain.Models;

public class Event : Model
{
    public const int TitleMaxLength = 100;
    public const int DescriptionMaxLength = 500;
    public const int LocationMaxLength = 100;

    private Event(
        Guid organizerId,
        string title,
        string description,
        DateTime date,
        string location,
        bool isPublic,
        int? capacity = null)
    {
        Title = title;
        Description = description;
        Date = date;
        Location = location;
        Capacity = capacity;
        IsPublic = isPublic;
        OrganizerId = organizerId;
    }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public DateTime Date { get; private set; }

    public string Location { get; private set; }

    public int? Capacity { get; private set; }

    public bool IsPublic { get; private set; }

    public Guid OrganizerId { get; private set; }

    public List<EventParticipant> EventParticipants { get; private set; } = [];

    public static Result<Event> Create(
        Guid organizerId,
        string title,
        string description,
        DateTime date,
        string location,
        bool isPublic,
        int? capacity = null)
    {
        var validationResult = Validate(title, description, date, location, capacity);
        if (validationResult.IsFailure)
        {
            return Result<Event>.Failure(validationResult.Error);
        }

        var eventInstance = new Event(organizerId, title, description, date, location, isPublic, capacity);
        return Result<Event>.Success(eventInstance);
    }

    public Result UpdateTitle(string title)
    {
        var validation = ValidateTitle(title);
        if (validation.IsFailure)
        {
            return validation;
        }

        Title = title;
        return Result.Success();
    }

    public Result UpdateDescription(string description)
    {
        var validation = ValidateDescription(description);
        if (validation.IsFailure)
        {
            return validation;
        }

        Description = description;
        return Result.Success();
    }

    public Result UpdateDate(DateTime date)
    {
        var validation = ValidateDate(date);
        if (validation.IsFailure)
        {
            return validation;
        }

        Date = date;
        return Result.Success();
    }

    public Result UpdateLocation(string location)
    {
        var validation = ValidateLocation(location);
        if (validation.IsFailure)
        {
            return validation;
        }

        Location = location;
        return Result.Success();
    }

    public Result UpdateCapacity(int? capacity)
    {
        var validation = ValidateCapacity(capacity);
        if (validation.IsFailure)
        {
            return validation;
        }

        Capacity = capacity;
        return Result.Success();
    }

    public Result UpdateVisibility(bool isPublic)
    {
        IsPublic = isPublic;
        return Result.Success();
    }

    private static Result Validate(string title, string description, DateTime date, string location, int? capacity)
    {
        var titleValidation = ValidateTitle(title);
        if (titleValidation.IsFailure)
        {
            return titleValidation;
        }

        var descriptionValidation = ValidateDescription(description);
        if (descriptionValidation.IsFailure)
        {
            return descriptionValidation;
        }

        var dateValidation = ValidateDate(date);
        if (dateValidation.IsFailure)
        {
            return dateValidation;
        }

        var locationValidation = ValidateLocation(location);
        if (locationValidation.IsFailure)
        {
            return locationValidation;
        }

        var capacityValidation = ValidateCapacity(capacity);
        if (capacityValidation.IsFailure)
        {
            return capacityValidation;
        }

        return Result.Success();
    }

    private static Result ValidateTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title) || title.Length > TitleMaxLength)
        {
            return Result.Failure(Error.Problem(
                "Event.InvalidTitle",
                $"Title cannot be empty or exceed maximum length of {TitleMaxLength} characters."));
        }

        return Result.Success();
    }

    private static Result ValidateDescription(string description)
    {
        if (description.Length > DescriptionMaxLength)
        {
            return Result.Failure(Error.Problem(
                "Event.InvalidDescription",
                $"Description cannot exceed maximum length of {DescriptionMaxLength} characters."));
        }

        return Result.Success();
    }

    private static Result ValidateDate(DateTime date)
    {
        if (date < DateTime.UtcNow)
        {
            return Result.Failure(Error.Problem(
                "Event.InvalidDate",
                "Date must be in the future."));
        }

        return Result.Success();
    }

    private static Result ValidateLocation(string location)
    {
        if (string.IsNullOrWhiteSpace(location) || location.Length > LocationMaxLength)
        {
            return Result.Failure(Error.Problem(
                "Event.InvalidLocation",
                $"Location cannot be empty or exceed maximum length of {LocationMaxLength} characters."));
        }

        return Result.Success();
    }

    private static Result ValidateCapacity(int? capacity)
    {
        if (capacity is <= 0)
        {
            return Result.Failure(Error.Problem(
                "Event.InvalidCapacity",
                "Capacity must be a positive integer or null."));
        }

        return Result.Success();
    }
}