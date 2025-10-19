using Domain.Models;
using Domain.Repositories;

namespace Persistence.Repositories;

public class UserRepository : IUserRepository
{
    public Task<User?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Add(User model)
    {
        throw new NotImplementedException();
    }

    public void Update(User model)
    {
        throw new NotImplementedException();
    }

    public void Delete(User model)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EmailExistsAsync(string email)
    {
        throw new NotImplementedException();
    }
}