using Domain.Abstraction;
using Domain.Shared.ErrorHandling;

namespace Domain.Models;

public class User : Model
{
    public const int FirstNameMaxLength = 50;
    public const int LastNameMaxLength = 50;
    public const int EmailMaxLength = 100;
    public const int PasswordHashMaxLength = 256;

    private User(string firstName, string lastName, string email, string passwordHash)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordHash = passwordHash;
    }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Email { get; private set; }

    public string PasswordHash { get; private set; }

    public static Result<User> Create(string firstName, string lastName, string email, string passwordHash)
    {
        var validationResult = Validate(firstName, lastName, email, passwordHash);
        if (validationResult.IsFailure)
        {
            return Result<User>.Failure(validationResult.Error);
        }

        var user = new User(firstName, lastName, email, passwordHash);
        return Result<User>.Success(user);
    }

    private static Result Validate(string firstName, string lastName, string email, string passwordHash)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            return Result.Failure(Error.Problem(
                "User.FirstName.Empty",
                "First name cannot be empty."));
        }

        if (firstName.Length > FirstNameMaxLength)
        {
            return Result.Failure(Error.Problem(
                "User.FirstName.TooLong",
                $"First name cannot exceed {FirstNameMaxLength} characters."));
        }

        if (string.IsNullOrWhiteSpace(lastName))
        {
            return Result.Failure(Error.Problem(
                "User.LastName.Empty",
                "Last name cannot be empty."));
        }

        if (lastName.Length > LastNameMaxLength)
        {
            return Result.Failure(Error.Problem(
                "User.LastName.TooLong",
                $"Last name cannot exceed {LastNameMaxLength} characters."));
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            return Result.Failure(Error.Problem(
                "User.Email.Empty",
                "Email cannot be empty."));
        }

        if (email.Length > EmailMaxLength)
        {
            return Result.Failure(Error.Problem(
                "User.Email.TooLong",
                $"Email cannot exceed {EmailMaxLength} characters."));
        }

        if (string.IsNullOrWhiteSpace(passwordHash))
        {
            return Result.Failure(Error.Problem(
                "User.PasswordHash.Empty",
                "Password hash cannot be empty."));
        }

        if (passwordHash.Length > PasswordHashMaxLength)
        {
            return Result.Failure(Error.Problem(
                "User.PasswordHash.TooLong",
                $"Password hash cannot exceed {PasswordHashMaxLength} characters."));
        }

        return Result.Success();
    }
}