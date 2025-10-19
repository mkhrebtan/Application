using Domain.Models;
using FluentValidation;

namespace Application.Commands.Events.UpdateLocation;

internal sealed class UpdateEventLocationCommandValidator : AbstractValidator<UpdateEventLocationCommand>
{
    public UpdateEventLocationCommandValidator()
    {
        RuleFor(x => x.EventId)
            .NotEmpty().WithMessage("EventId is required.");

        RuleFor(x => x.Location)
            .NotEmpty().WithMessage("Location is required.")
            .MaximumLength(Event.LocationMaxLength).WithMessage("Location cannot exceed {MaxLength} characters.");
    }
}