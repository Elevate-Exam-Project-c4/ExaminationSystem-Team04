namespace exam_system.Persistence.DataAccess;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}
