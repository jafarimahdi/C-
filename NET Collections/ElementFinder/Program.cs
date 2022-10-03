using System;
using System.Collections.Generic;

namespace ElementFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };

            // Add a method called `ContainsSeven` that checks if the `List` contains the number 7
            // If it does the method should return "Hoorray" otherwise return "Noooooo"

            // The output should be "Noooooo"
            Console.WriteLine(ContainsSeven(List));

            // Add a method called `ContainsSevenDifferent` which implements the same behavior differently
            // (e.g. using different list methods)

            // The output should be "Noooooo", again!
            Console.WriteLine(ContainsSevenDifferent(List));
        }


        public static string ContainsSeven(List<int> list)
        {
            string result = list.Contains(7) ? "Hoorray" : "Noooooo";
            return result;
        }


        public static string ContainsSevenDifferent(List<int> list)
        {
            string result = "";
            foreach (var item in list)
            {
                if (item == 7)
                {
                    result = "Hoorray";
                }
                result = "Nooooo";
            }
            return result;
        }
    }
}

