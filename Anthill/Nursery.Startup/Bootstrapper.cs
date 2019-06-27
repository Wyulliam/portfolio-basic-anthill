using Microsoft.Extensions.DependencyInjection;
using Nursery.Core;
using Nursery.Core.Factory;
using Nursery.Core.Repositories;
using Nursery.Data.Repositories;

namespace Nursery.Startup
{
    public static class Bootstrapper
    {
        public static IServiceCollection RegisterNurseryServices(this IServiceCollection services)
        {
            services.AddScoped<INursery, Core.Nursery>();
            services.AddScoped<INurseryAbstractFactory, NurseryAbstractFactory>();

            services.AddScoped<IAntTypeRepository, AntTypeRepository>();
            services.AddScoped<IEggRepository, EggRepository>();
            return services;
        }
    }
}
