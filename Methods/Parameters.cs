using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class Parameters
    {
        public static void ShowParameters()
        {
            // Paramter here is hello
            Console.WriteLine("Hello");
            Console.WriteLine(Add(5, 5));

            int firstNum = ReadInt("Enter first number");
            int secondNum = ReadInt("Enter second number");
            int result = Add(firstNum, secondNum);

            Console.WriteLine(result);

            string name = ReadString("Enter your name");
            int age = ReadInt("Enter your age");
            string details = UserDetails(name, age);

            Console.WriteLine(details);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static string ReadString(string message)
        {
            Console.WriteLine($"{message}: ");
            return Convert.ToString(Console.ReadLine());
        }

        public static int ReadInt(string message)
        {
            Console.WriteLine($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}";
        }
    }
}
