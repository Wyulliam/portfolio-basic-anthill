using Anthill.Core;
using System;
using System.Linq;

namespace Anthill.Service.Menus
{
    static class LayEggsMenu
    {
        public static void LayEggs(IQueen queen)
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
    }
}
