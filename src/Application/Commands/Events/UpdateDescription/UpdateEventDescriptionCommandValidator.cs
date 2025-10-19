using Domain.Models;
using FluentValidation;

namespace Application.Commands.Events.UpdateDescription;

internal sealed class UpdateEventDescriptionCommandValidator : AbstractValidator<UpdateEventDescriptionCommand>
{
    public UpdateEventDescriptionCommandValidator()
    {
        RuleFor(x => x.EventId)
            .NotEmpty().WithMessage("EventId is required.");

        RuleFor(x => x.Description)
            .MaximumLength(Event.DescriptionMaxLength).WithMessage("Description cannot exceed {MaxLength} characters.");
    }
}