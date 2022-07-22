namespace EcommerceExample.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddAutoMapper(typeof(DependencyInjection).Assembly);
        return services;
    }
    
}