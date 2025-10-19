using Domain.Models;
using FluentValidation;

namespace Application.Commands.Users.Signup;

internal sealed class SignupUserCommandValidator : AbstractValidator<SignupUserCommand>
{
    public SignupUserCommandValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("First name is required.")
            .MaximumLength(User.FirstNameMaxLength).WithMessage("First name must not exceed {MaxLength} characters.");

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Last name is required.")
            .MaximumLength(User.LastNameMaxLength).WithMessage("Last name must not exceed {MaxLength} characters.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required.")
            .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");
    }
}