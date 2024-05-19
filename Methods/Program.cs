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
            // Public static void
            Test.Something();

            // Public void
            Test test = new Test();
            test.AnotherSomething();

            WelcomeMessage();

            Console.ReadLine();
        }

        // static = accessed anywhere from everywhere (no need for declaration of instance)
        // 
        static void WelcomeMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}
