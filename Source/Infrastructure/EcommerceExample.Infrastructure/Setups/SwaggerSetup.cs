namespace EcommerceExample.Infrastructure.Setups;

public static class SwaggerSetup
{
    public static IServiceCollection AddSwaggerSetup(this IServiceCollection services)
    {
        return services
            .AddEndpointsApiExplorer()
            .AddSwaggerGen();
    }

    public static IApplicationBuilder UseSwaggerSetup(this IApplicationBuilder app)
    {
        return app
            .UseSwagger()
            .UseSwaggerUI();
    }
}

public static class HealthCheckSetup
{
    public static IServiceCollection AddHealthCheckSetup(this IServiceCollection services)
    {
        return services.AddHealthChecks().Services;
    }

    public static IApplicationBuilder UseHealthCheckSetup(this IApplicationBuilder app, string healthCheckPath)
    {
        return app.UseHealthChecks(healthCheckPath);
    }
}