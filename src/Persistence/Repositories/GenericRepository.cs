using Domain.Abstraction;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class GenericRepository<TModel> : IRepository<TModel>
    where TModel : Model
{
    protected readonly ApplicationDbContext _context;

    protected readonly DbSet<TModel> _dbSet;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TModel>();
    }

    public Task<TModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return _dbSet.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
    }

    public void Add(TModel model)
    {
        _dbSet.Add(model);
    }

    public void Update(TModel model)
    {
        _dbSet.Update(model);
    }

    public void Delete(TModel model)
    {
        _dbSet.Remove(model);
    }
}