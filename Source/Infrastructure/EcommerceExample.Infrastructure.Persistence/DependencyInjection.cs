namespace EcommerceExample.Infrastructure.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString) =>
        services
            .AddSqlServer<DataContext>(connectionString)
            .AddScoped<IProductRepository, ProductRepository>();
}