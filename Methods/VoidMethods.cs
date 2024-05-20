using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class VoidMethods
    {
        public static void ShowVoidMethods()
        {
            // Define back a bool
            bool success = int.TryParse(Console.ReadLine(), out var result);
            Console.WriteLine(success);

            string test = "Hello";
            test.Replace(test, "Bye");

            StringBuilder sb = new StringBuilder();
            sb.Replace(test, "Hello");

            // Does not return but just changes passed value
            // Array.Reverse();

            // numbers from CreateAndPrintArray not accessible here

        }

        public static void CreateAndPrintArray()
        {
            int[] numbers = new int[3] { 0, 1, 2 };

            foreach (int item in numbers)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void ShowWelcomeMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}
