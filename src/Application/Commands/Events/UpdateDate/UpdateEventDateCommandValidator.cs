using FluentValidation;

namespace Application.Commands.Events.UpdateDate;

internal sealed class UpdateEventDateCommandValidator : AbstractValidator<UpdateEventDateCommand>
{
    public UpdateEventDateCommandValidator()
    {
        RuleFor(x => x.EventId)
            .NotEmpty().WithMessage("EventId is required.");

        RuleFor(x => x.Date)
            .GreaterThan(DateTime.UtcNow).WithMessage("Date cannot be in the past.");
    }
}