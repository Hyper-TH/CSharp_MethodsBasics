using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Methods
{
    public static class OutParameters
    {
        public static void ShowOutParameters()
        {
            int num = 0;

            bool success = test(out num);
            Console.WriteLine(num);
            Console.WriteLine(success);

            // int.TryParse();

            List<string> shoppingList = new List<string>()
            {
                "Coffee", "Milk"
            };

            // Console.WriteLine(shoppingList.IndexOf("Coffee"));
            // Console.WriteLine(FindInList("Milk", shoppingList, out int index));
            // Console.WriteLine(" " + index);
            Console.WriteLine("Enter an item to searc: ");
            string search = Console.ReadLine();

            if (FindInList(search, shoppingList, out int index))
            {
                Console.WriteLine($"Found {search} at index {index}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        static bool test(out int num)
        {
            num = 5;
            return true;
        } 

        static bool TryParse(string s, out int result)
        {
            result = 0;
            return true;
        }

        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }

            return index > -1;
        }
        
    }
}
