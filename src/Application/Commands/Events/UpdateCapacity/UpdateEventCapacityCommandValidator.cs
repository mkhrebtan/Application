using FluentValidation;

namespace Application.Commands.Events.UpdateCapacity;

internal sealed class UpdateEventCapacityCommandValidator : AbstractValidator<UpdateEventCapacityCommand>
{
    public UpdateEventCapacityCommandValidator()
    {
        RuleFor(x => x.EventId)
            .NotEmpty().WithMessage("EventId is required.");

        RuleFor(x => x.Capacity)
            .GreaterThan(0)
            .When(x => x.Capacity.HasValue).WithMessage("Capacity must be greater than zero if specified.");
    }
}