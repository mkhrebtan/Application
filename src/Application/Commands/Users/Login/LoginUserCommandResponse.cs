namespace Application.Commands.Users.Login;

public record LoginUserCommandResponse(string AccessToken, string RefreshToken);