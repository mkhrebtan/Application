using Domain.Models;

namespace Domain.Repositories;

public interface IRefreshTokenRepository : IRepository<RefreshToken>
{
    Task<RefreshToken?> GetByTokenAsync(string token);

    Task<IEnumerable<RefreshToken>> GetByUserIdAsync(Guid userId);
}