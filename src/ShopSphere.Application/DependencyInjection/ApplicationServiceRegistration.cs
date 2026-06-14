using Microsoft.Extensions.DependencyInjection;
using ShopSphere.Application.Interfaces;
using ShopSphere.Application.Services;

namespace ShopSphere.Application.DependencyInjection;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection
        AddApplicationServices(
            this IServiceCollection services)
    {
        services.AddScoped<
            IProductService,
            ProductService>();

        return services;
    }
}