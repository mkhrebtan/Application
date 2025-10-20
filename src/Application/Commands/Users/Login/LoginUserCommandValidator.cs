using FluentValidation;

namespace Application.Commands.Users.Login;

internal sealed class LoginUserCommandValidator : AbstractValidator<LoginUserCommand>
{
    public LoginUserCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required.")
            .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");

        RuleFor(x => x.VisitorId)
            .NotEmpty().WithMessage("VisitorId is required.")
            .NotEqual(Guid.Empty).WithMessage("VisitorId must be a valid GUID.");
    }
}