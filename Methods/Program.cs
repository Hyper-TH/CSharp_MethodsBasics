using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Test
    {
        // This has to be public to be accessed by other classes
        public static void Something()
        {
            Console.WriteLine("Public static void from class test");
        }

        // An instance has to be declared
        public void AnotherSomething()
        {
            Console.WriteLine("Public void from class test");
        }
    }

    class Program
    {
        static void Main()
        {
            // Title of console
            // Console.Title = $"{ReturnType.ReturnName()} - {ReturnType.ReturnAge()}";

            // ReturnType.PrintIntroduction();

            // Public static void
            // Test.Something();

            // Public void
            // Test test = new Test();
            // test.AnotherSomething();

            // WelcomeMessage();


            // VoidMethods.ShowVoidMethods();
            // VoidMethods.CreateAndPrintArray();
            // VoidMethods.ShowWelcomeMessage();

            // int[] numbers = new int[3];
            /* for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReturnType.ReadNumberFromConsole();
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");
            }

            int[] newNumbers = ReturnType.CreateRandomArray();

            foreach (var item in newNumbers)
            {
                Console.WriteLine($"{item} ");
            }
            */

            // Parameters.ShowParameters();
            // Optional.ShowOptional();
            // Named.ShowNamed();
            // OutParameters.ShowOutParameters();
            // ReferenceParameters.ShowReferenceParameters();

            /* Excercise 1 */
            /*
             * Ask user for width and height, store them
             * Create function to calculate the area
             * Function should calculate the area using (w x h)/2
             * Call in main and print out the area of the triangle
            */
            double width = ReadDouble("width");
            double height = ReadDouble("height");

            Console.WriteLine($"Width: {width} \nHeight: {height}\n");
            double area = CalculateArea(ref width, ref height);

            Console.WriteLine($"Area {area}");

            Console.ReadLine();
        }

        // static = accessed anywhere from everywhere (no need for declaration of instance)
        static void WelcomeMessage()
        {
            Console.WriteLine("Hello World");
        }

        static double ReadDouble(string message)
        {
            Console.WriteLine($"Input {message}");
            return Convert.ToDouble(Console.ReadLine());
        }

        static double CalculateArea(ref double width, ref double height)
        {
            return (width * height)/2;
        }

    }
}
