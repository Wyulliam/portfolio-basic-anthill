using Colony.Core;
using Colony.Core.Factory;
using Colony.Core.Repositories;
using Colony.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Colony.Startup
{
    public static class Bootstrapper
    {
        public static IServiceCollection RegisterColonyServices(this IServiceCollection services)
        {
            services.AddScoped<IColony, Core.Colony>();
            services.AddScoped<IColonyAbstractFactory, ColonyAbstractFactory>();

            services.AddScoped<IAntsRepository, AntsRepository>();

            return services;
        }
    }
}
