using Cemetery.Core;
using Cemetery.Core.Factory;
using Cemetery.Core.Repositories;
using Cemetery.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Cemetery.Startup
{
    public static class Bootstrapper
    {
        public static IServiceCollection RegisterCemeteryServices(this IServiceCollection services)
        {
            services.AddScoped<ICemetery, Core.Cemetery>();
            services.AddScoped<ICemeteryAbstractFactory, CemeteryAbstractFactory>();

            services.AddScoped<ICorpseRepository, CorpseRepository>();

            return services;
        }
    }
}
