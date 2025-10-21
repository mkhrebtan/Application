namespace Application.Commands.Users.RefreshToken;

public record RefreshTokenCommandResponse(string AccessToken, string RefreshToken);