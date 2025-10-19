using Domain.Models;
using FluentValidation;

namespace Application.Commands.Events.Create;

internal sealed class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
{
    public CreateEventCommandValidator()
    {
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

        RuleFor(x => x.Capacity)
            .GreaterThan(0)
            .When(x => x.Capacity.HasValue).WithMessage("Capacity must be greater than zero if specified.");
    }
}