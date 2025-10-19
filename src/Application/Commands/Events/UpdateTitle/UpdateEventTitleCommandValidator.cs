using Domain.Models;
using FluentValidation;

namespace Application.Commands.Events.UpdateTitle;

internal sealed class UpdateEventTitleCommandValidator : AbstractValidator<UpdateEventTitleCommand>
{
    public UpdateEventTitleCommandValidator()
    {
        RuleFor(x => x.EventId)
            .NotEmpty().WithMessage("EventId is required.");

        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required.")
            .MaximumLength(Event.TitleMaxLength).WithMessage("Title cannot exceed {MaxLength} characters.");
    }
}