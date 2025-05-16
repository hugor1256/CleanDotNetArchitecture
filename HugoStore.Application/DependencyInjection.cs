using Microsoft.Extensions.DependencyInjection;

namespace HugoStore.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(s =>
        {
            s.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
        });
        
        return services;
    }
}