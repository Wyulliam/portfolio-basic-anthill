using Anthill.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anthill.Service.Menus
{
    static class CreateTypeMenu
    {
        public static void CreateAntType(IQueen queen)
        {
            Console.Clear();

            Console.WriteLine("How is the new type called?");

            var type = "";
            while (true)
            {
                type = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(type))
                {
                    Console.WriteLine("Please insert a valid type.");
                    continue;
                }

                break;
            }

            var result = queen.CreateType(type);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
