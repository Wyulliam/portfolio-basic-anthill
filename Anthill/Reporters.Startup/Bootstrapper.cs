using Microsoft.Extensions.DependencyInjection;
using Reporters.Core;
using System;

namespace Reporters.Startup
{
    public static class Bootstrapper
    {
        public static IServiceCollection RegisterReportersServices(this IServiceCollection services)
        {

            return services;
        }
    }
}
