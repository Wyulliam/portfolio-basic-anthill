using Microsoft.Extensions.DependencyInjection;
using Nursery.Core;
using Nursery.Core.Factory;

namespace Nursery.Startup
{
    public static class Bootstrapper
    {
        public static IServiceCollection RegisterNurseryServices(this IServiceCollection services)
        {
            services.AddScoped<INursery, Core.Nursery>();
            services.AddScoped<INurseryAbstractFactory, NurseryAbstractFactory>();

            return services;
        }
    }
}
