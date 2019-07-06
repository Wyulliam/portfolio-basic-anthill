using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Nursery.Core;
using Nursery.Core.Factory;
using Nursery.Core.Repositories;
using Nursery.Data.Repositories;
using System;

namespace Nursery.Startup
{
    public static class Bootstrapper
    {
        public static IServiceCollection RegisterNurseryServices(this IServiceCollection services)
        {
            var core = AppDomain.CurrentDomain.Load("Nursery.Core");
            services.AddMediatR(core);

            services.AddScoped<INursery, Core.Nursery>();
            services.AddScoped<INurseryAbstractFactory, NurseryAbstractFactory>();

            services.AddScoped<IAntTypeRepository, AntTypeRepository>();
            services.AddScoped<IEggRepository, EggRepository>();
            return services;
        }
    }
}
