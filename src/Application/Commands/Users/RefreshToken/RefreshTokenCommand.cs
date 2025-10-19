using Application.Abstraction.Mediator;

namespace Application.Commands.Users.RefreshToken;

public record RefreshTokenCommand(string RefreshToken) : ICommand<RefreshTokenCommandResponse>;