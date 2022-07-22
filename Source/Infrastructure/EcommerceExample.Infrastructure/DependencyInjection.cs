namespace EcommerceExample.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string allowOrigin, string connectionString)
    {
        return services
            .AddPersistence(connectionString)
            .AddSwaggerSetup()
            .AddCorsSetup(allowOrigin)
            .AddHealthCheckSetup()
            .AddMediatorSetup();
    }
    
    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app, bool showSwagger, string healthCheckPath)
    {
        if (showSwagger)
            app.UseSwaggerSetup();
        
        return app
            .UseHealthCheckSetup(healthCheckPath)
            .UseCorsSetup();
    }
}