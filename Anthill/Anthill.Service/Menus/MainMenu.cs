using Anthill.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anthill.Service.Menus
{
    static class MainMenu
    {
        public static void StartWorking(IQueen queen)
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
                        LayEggsMenu.LayEggs(queen);
                        break;
                    case '2':
                        CreateTypeMenu.CreateAntType(queen);
                        break;
                    case '3':
                        CheckAnthillMenu.CheckAnthill(queen);
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
    }
}
