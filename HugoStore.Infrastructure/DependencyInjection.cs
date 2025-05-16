using HugoStore.Domain.Repositories;
using HugoStore.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HugoStore.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IProductRepository, ProductRepository>();

        return services;
    }
}