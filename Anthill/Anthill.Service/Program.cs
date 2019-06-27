using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Anthill.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup.Startup>();

        }
    }
}
