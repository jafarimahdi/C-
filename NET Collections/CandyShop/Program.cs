using System;
using System.Collections.Generic;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the `list`
            // Your task is to change the "2" to "Croissant" and change the "false" to "Ice cream"
            // No, don't just edit the lines above! :)
            // Create a method called "RepairSweetList()" which takes the `list` as a parameter
            // and returns a list with the items "2" and "false" replaced (with "Croissant" and "Ice cream")

            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"

            RepairSweetList(list);
        }

        public static void RepairSweetList(List<object> list)
        {
            int indexOf2 = list.IndexOf(2);
            int indexOfFalse = list.IndexOf(false);

            if (indexOf2 != -1)
            {
                list[indexOf2] = "Croissant";
            }
            if (indexOfFalse != -1)
            {
                list[indexOfFalse] = "Ice cream";
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

        }
    }
}

