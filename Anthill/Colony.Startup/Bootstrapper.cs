using Colony.Core;
using Colony.Core.Factory;
using Colony.Core.Repositories;
using Colony.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Colony.Startup
{
    public static class Bootstrapper
    {
        public static IServiceCollection RegisterColonyServices(this IServiceCollection services)
        {
            var core = AppDomain.CurrentDomain.Load("Colony.Core");
            services.AddMediatR(core);

            services.AddScoped<IColony, Core.Colony>();
            services.AddScoped<IColonyAbstractFactory, ColonyAbstractFactory>();

            services.AddScoped<IAntsRepository, AntsRepository>();

            return services;
        }
    }
}
