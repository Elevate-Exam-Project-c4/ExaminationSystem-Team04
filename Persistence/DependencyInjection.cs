using exam_system.Persistence.DataAccess;

namespace exam_system.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}
