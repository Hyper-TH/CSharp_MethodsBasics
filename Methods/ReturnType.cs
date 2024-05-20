using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class ReturnType
    {
        public static string ReturnName()
        {
            return "Hyper";
        }

        public static int ReturnAge()
        {
            return 42;
        }

        public static void PrintIntroduction()
        {
            Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}");
        }

        public static int[] CreateRandomArray()
        {
            return new int[3]
            {
                0, 1, 2
            };
        }

        public static int ReadNumberFromConsole()
        {
            Console.WriteLine("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
