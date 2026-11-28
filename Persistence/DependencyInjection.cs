using exam_system.Persistence.DataAccess;

namespace exam_system.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        services.AddScoped<IGenericRepository,GenericRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}
