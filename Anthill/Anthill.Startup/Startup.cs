using Colony.Startup;
using Microsoft.Extensions.DependencyInjection;
using Reporters.Startup;

namespace Anthill.Startup
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.RegisterColonyServices();
            services.RegisterReportersServices();
        }
    }
}
