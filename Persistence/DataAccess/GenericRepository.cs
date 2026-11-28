using exam_system.Domain.Common;
using exam_system.Common.Interfaces;
using exam_system.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace exam_system.Persistence.DataAccess;

public class GenericRepository<T, TId> : IGenericRepository<T, TId>
    where T : BaseEntity<TId>
{
    private readonly DbSet<T> _entities;

    public GenericRepository(AppDbContext context)
    {
        _entities = context.Set<T>();
    }

    public async Task<T?> GetByIdAsync(TId id)
        => await _entities.FindAsync(id);

    public Task<List<T>> GetAllAsync()
        => _entities.ToListAsync();

    public async Task AddAsync(T entity)
        => await _entities.AddAsync(entity);

    public void Update(T entity) => _entities.Update(entity);

    public void Delete(T entity) => _entities.Remove(entity);

    public void SoftDelete(T entity)
    {
        if (entity is not ISoftDeletable softDeletable)
            throw new InvalidOperationException($"{typeof(T).Name} does not support soft delete.");

        softDeletable.IsDeleted = true;
        softDeletable.DeletedAt = DateTime.UtcNow;
        _entities.Update(entity);
    }
}
