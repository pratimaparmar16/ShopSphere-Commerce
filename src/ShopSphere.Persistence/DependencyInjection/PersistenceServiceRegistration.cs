using Microsoft.Extensions.DependencyInjection;
using ShopSphere.Application.Interfaces;
using ShopSphere.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShopSphere.Persistence.DependencyInjection
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();

            return services;
        }
    }
}
