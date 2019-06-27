using Microsoft.Extensions.DependencyInjection;
using Reporters.Core;
using Reporters.Core.Factory;

namespace Reporters.Startup
{
    public static class Bootstrapper
    {
        public static IServiceCollection RegisterReportersServices(this IServiceCollection services)
        {
            services.AddScoped<IReporter, Reporter>();
            services.AddScoped<IReporterAbstractFactory, ReporterAbstractFactory>();

            return services;
        }
    }
}
