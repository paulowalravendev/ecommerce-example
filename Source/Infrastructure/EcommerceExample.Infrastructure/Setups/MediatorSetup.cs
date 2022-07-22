namespace EcommerceExample.Infrastructure.Setups;

public static class MediatorSetup
{
    public static IServiceCollection AddMediatorSetup(this IServiceCollection services)
    {
        return services.AddMediatR(typeof(Application.DependencyInjection));
    }
}