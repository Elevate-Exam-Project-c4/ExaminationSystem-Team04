using exam_system.Persistence.Context;

namespace exam_system.Persistence.DataAccess;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public Task<int> SaveChangesAsync()
        => _context.SaveChangesAsync();
}
