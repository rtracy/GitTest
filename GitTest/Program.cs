using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            C();
        }

        private static void A()
        {
            Console.WriteLine("Change D-A");
        }

        private static void B()
        {

        }

        private static void C()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello world!");
            Console.ResetColor();
            Console.WriteLine("bye world!");
        }

    }
}
