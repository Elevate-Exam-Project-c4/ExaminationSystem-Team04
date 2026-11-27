using exam_system.Domain.Common;

namespace exam_system.Persistence.DataAccess;

public interface IGenericRepository<T, TId>
    where T : BaseEntity<TId>
{
}
