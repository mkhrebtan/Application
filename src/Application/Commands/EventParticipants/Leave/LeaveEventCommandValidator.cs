using FluentValidation;

namespace Application.Commands.EventParticipants.Leave;

internal sealed class LeaveEventCommandValidator : AbstractValidator<LeaveEventCommand>
{
    public LeaveEventCommandValidator()
    {
        RuleFor(x => x.EventId)
            .NotEmpty().WithMessage("EventId is required.");

        RuleFor(x => x.VisitorId)
            .NotEmpty().WithMessage("VisitorId is required when no authenticated user is present.")
            .When(x => x.VisitorId.HasValue);
    }
}