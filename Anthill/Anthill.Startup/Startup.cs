using Colony.Startup;
using Microsoft.Extensions.DependencyInjection;

namespace Anthill.Startup
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.RegisterColonyServices();
        }
    }
}
