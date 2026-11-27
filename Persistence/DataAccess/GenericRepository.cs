using exam_system.Domain.Common;

namespace exam_system.Persistence.DataAccess;

public class GenericRepository<T, TId> : IGenericRepository<T, TId>
    where T : BaseEntity<TId>
{
}
