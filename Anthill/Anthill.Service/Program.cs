using System;
using System.Linq;
using Anthill.Core;
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
            var working = true;
            while (working)
            {
                Console.WriteLine("1 - Lay Eggs");
                Console.WriteLine("2 - Create New Ant Type");
                Console.WriteLine("3 - Check Anthill");
                Console.WriteLine("0 - Stop Working");

                var option = Console.ReadKey().KeyChar;

                switch (option)
                {
                    case '1':
                        LayEggs(queen);
                        break;
                    case '2':
                        CreateAntType(queen);
                        break;
                    case '3':
                        CheckAnthill(queen);
                        break;
                    case '0':
                        working = false;
                        break;
                    default:
                        Console.WriteLine("Please type a valid option.");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();
            }
        }

        private static void CreateAntType(IQueen queen)
        {
            Console.Clear();

            Console.WriteLine("How is the new type called?");
            var type = "";

            while (true)
            {
                type = Console.ReadLine();

                if (type == "")
                {
                    Console.WriteLine("Please insert a valid type.");
                    continue;
                }

                break;
            }

            Console.WriteLine(queen.CreateType(type));

            Console.ReadKey();
        }

        private static void LayEggs(IQueen queen)
        {
            Console.Clear();

            var availableTypes = queen.GetAntTypes();

            if (!availableTypes.Any())
            {
                Console.WriteLine("You need to create a type first.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Wich Type? (0 to Return)");
            Console.WriteLine($"Available types: {string.Join(',', availableTypes)}");

            var type = "";
            while (true)
            {
                type = Console.ReadLine();
                if (type == "0")
                    return;

                if (!availableTypes.Any(a => a.ToLower() == type.ToLower()))
                {
                    Console.WriteLine("Please insert a valid type");
                    continue;
                }

                break;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("How Many? (0 to Return)");

            int quantity = int.MinValue;

            while (true)
            {
                int.TryParse(Console.ReadLine(), out quantity);

                if (quantity == 0)
                    return;

                if (quantity == int.MinValue)
                {
                    Console.WriteLine("Please insert a valid quantity");
                    continue;
                }

                break;
            }

            Console.WriteLine(queen.LayEggs(quantity, type));

            Console.ReadKey();
        }

        private static void CheckAnthill(IQueen queen)
        {
            Console.Clear();
            var report = queen.CheckAnthill();
            Console.WriteLine(report);

            Console.ReadKey();
        }
    }
}
