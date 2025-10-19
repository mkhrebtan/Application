using Application.Abstraction.Mediator;

namespace Application.Commands.Users.Login;

public record LoginUserCommand(string Email, string Password) : ICommand<LoginUserCommandResponse>;