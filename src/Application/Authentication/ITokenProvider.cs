using Domain.Models;

namespace Application.Authentication;

public interface ITokenProvider
{
    string GenerateAccessToken(User user);

    RefreshToken GenerateRefreshToken(User user);
}