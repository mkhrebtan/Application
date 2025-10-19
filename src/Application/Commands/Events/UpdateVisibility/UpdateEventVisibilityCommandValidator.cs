using FluentValidation;

namespace Application.Commands.Events.UpdateVisibility;

internal sealed class UpdateEventVisibilityCommandValidator : AbstractValidator<UpdateEventVisibilityCommand>
{
    public UpdateEventVisibilityCommandValidator()
    {
        RuleFor(x => x.EventId)
            .NotEmpty().WithMessage("EventId is required.");
    }
}