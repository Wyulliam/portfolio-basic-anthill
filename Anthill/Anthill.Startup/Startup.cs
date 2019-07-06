using Anthill.Core;
using Cemetery.Startup;
using Colony.Startup;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Nursery.Startup;
using Reporters.Startup;

namespace Anthill.Startup
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.RegisterColonyServices();
            services.RegisterReportersServices();
            services.RegisterNurseryServices();
            services.RegisterCemeteryServices();

            services.AddScoped<IQueen, Queen>();
        }
        public void Configure(IApplicationBuilder app)
        {

        }
    }
}
