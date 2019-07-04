using Anthill.Core;
using System;

namespace Anthill.Service.Menus
{
    static class CheckAnthillMenu
    {
        public static void CheckAnthill(IQueen queen)
        {
            Console.Clear();
            var report = queen.CheckAnthill();
            Console.WriteLine(report);

            Console.ReadKey();
        }
    }
}
