using Application.Mediator;

namespace Application.Commands.Users.Signup;

public record SignupUserCommand(string FirstName, string LastName, string Email, string Password, Guid VisitorId)
    : ICommand<SignupUserCommandResponse>;