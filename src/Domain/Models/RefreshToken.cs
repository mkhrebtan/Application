using Domain.Abstraction;

namespace Domain.Models;

public class RefreshToken(Guid userId, string token, DateTime expiresAt) : Model
{
    public Guid UserId { get; private set; } = userId;

    public string Token { get; private set; } = token;

    public DateTime ExpiresAt { get; private set; } = expiresAt;

    public bool IsRevoked { get; private set; }

    public User? User { get; set; }

    public void Revoke()
    {
        IsRevoked = true;
    }
}