using exam_system.Domain.Common;

namespace exam_system.Persistence.DataAccess;

public interface IGenericRepository<T, TId>
    where T : BaseEntity<TId>
{
    Task<T?> GetByIdAsync(TId id);
    Task<List<T>> GetAllAsync();
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    void SoftDelete(T entity);
}
