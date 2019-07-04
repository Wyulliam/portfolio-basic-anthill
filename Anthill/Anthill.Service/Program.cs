using System;
using System.Linq;
using Anthill.Core;
using Anthill.Service.Menus;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Anthill.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = WebHost.CreateDefaultBuilder(args).UseStartup<Startup.Startup>().Build();

            var queen = (IQueen)host.Services.GetService(typeof(IQueen));

            StartWorking(queen);
        }

        private static void StartWorking(IQueen queen)
        {
            MainMenu.StartWorking(queen);
        }
    }
}
