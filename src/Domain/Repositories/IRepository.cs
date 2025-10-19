using Domain.Abstraction;

namespace Domain.Repositories;

public interface IRepository<TModel>
    where TModel : Model
{
    Task<TModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    void Add(TModel model);

    void Update(TModel model);

    void Delete(TModel model);
}