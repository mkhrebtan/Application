using Domain.Models;
using FluentValidation;

namespace Application.Commands.Events.Update;

internal sealed class UpdateEventCommandValidator : AbstractValidator<UpdateEventCommand>
{
    public UpdateEventCommandValidator()
    {
        RuleFor(x => x.EventId)
            .NotEmpty().WithMessage("EventId is required.");

        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required.")
            .MaximumLength(Event.TitleMaxLength).WithMessage("Title cannot exceed {MaxLength} characters.");

        RuleFor(x => x.Description)
            .MaximumLength(Event.DescriptionMaxLength).WithMessage("Description cannot exceed {MaxLength} characters.");

        RuleFor(x => x.Date)
            .GreaterThan(DateTime.UtcNow).WithMessage("Date cannot be in the past.");

        RuleFor(x => x.Location)
            .NotEmpty().WithMessage("Location is required.")
            .MaximumLength(Event.LocationMaxLength).WithMessage("Location cannot exceed {MaxLength} characters.");

        RuleFor(x => x.Capacity.Value)
            .GreaterThan(0).When(x => x.Capacity is { IsSpecified: true, Value: not null, })
            .WithMessage("Capacity must be greater than 0.");
    }
}