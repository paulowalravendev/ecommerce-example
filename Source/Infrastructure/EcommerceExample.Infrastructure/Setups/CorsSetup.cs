namespace EcommerceExample.Infrastructure.Setups;

public static class CorsSetup
{
    public static IServiceCollection AddCorsSetup(this IServiceCollection services, string allowOrigin)
    {
        return services.AddCors(options =>
        {
            options.AddPolicy("default", policy =>
            {
                policy
                    .WithOrigins(allowOrigin)
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });  
    }

    public static IApplicationBuilder UseCorsSetup(this IApplicationBuilder app)
    {
        return app.UseCors("default");
    }
}