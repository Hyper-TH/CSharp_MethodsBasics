using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class Named
    {
        public static void ShowNamed()
        {
            string nameInput = "Hyper";
            int ageInput = 23;
            string addressInput = "1 Something Road";

            PrintDetails(age: ageInput, 
                        name: nameInput, 
                        address: addressInput);
        }

        public static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
