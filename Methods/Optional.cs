using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class Optional
    {
        public static void ShowOptional()
        {
            int result = Add(5);    // Returns 55
            Console.WriteLine(result);

            PrintName();    // Prints hyper
        }
        
        // 50 is optional
        public static int Add(int a, int b = 50)
        {
            return a + b;
        }

        public static void PrintName(string name = "Hyper")
        {
            Console.WriteLine(name);
        }
    }
}
