using Application.Mediator;

namespace Application.Commands.Users.Login;

public record LoginUserCommand(string Email, string Password, Guid VisitorId) : ICommand<LoginUserCommandResponse>;