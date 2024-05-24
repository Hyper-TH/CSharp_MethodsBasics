using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class ReferenceParameters
    {
        public static void ShowReferenceParameters()
        {
            int num = 10;
            string name = "Hyper";
            Assign(ref num, ref name);

            Console.WriteLine(num + name);

            string newName = Console.ReadLine();
            if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}!");

            }
            else
            {
                Console.WriteLine("New name cannot be empty or null!");
            }

        }

        // Pass by reference
        // If using out, you have to use the value
        static void Assign(ref int num, ref string name)
        {
            name = "Max";
            num = 20;
        }

        static bool ChangeName(ref string name, string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }

            return false;
        }
    }
}
