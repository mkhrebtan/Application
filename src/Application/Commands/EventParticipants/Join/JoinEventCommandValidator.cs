using FluentValidation;

namespace Application.Commands.EventParticipants.Join;

internal sealed class JoinEventCommandValidator : AbstractValidator<JoinEventCommand>
{
    public JoinEventCommandValidator()
    {
        RuleFor(x => x.EventId)
            .NotEmpty().WithMessage("EventId is required.");

        RuleFor(x => x.VisitorId)
            .NotEmpty().WithMessage("VisitorId is required when no authenticated user is present.")
            .When(x => x.VisitorId.HasValue);

        RuleFor(x => x.VisitorFirstName)
            .NotEmpty().WithMessage("VisitorFirstName is required.")
            .When(x => x.VisitorId.HasValue);

        RuleFor(x => x.VisitorLastName)
            .NotEmpty().WithMessage("VisitorLastName is required.")
            .When(x => x.VisitorId.HasValue);

        RuleFor(x => x.VisitorEmail)
            .NotEmpty().WithMessage("VisitorEmail is required.")
            .EmailAddress().WithMessage("VisitorEmail must be a valid email address.")
            .When(x => x.VisitorId.HasValue);
    }
}