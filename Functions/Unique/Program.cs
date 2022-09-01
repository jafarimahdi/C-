using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a method that takes an array of integers as a parameter
            //  and returns an array of integers where every integer is unique (occurs only once)

            //  Example
            Console.WriteLine(FindUniqueItems(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));

            //  should print: `[1, 11, 34, 52, 61]`

        }

        public static string FindUniqueItems(int[] myArray)
        {
            List<int> changeToList = myArray.ToList<int>();
            List<int> result = new List<int>();

            foreach (int item in changeToList)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            var convertToArray = result.ToArray();
            return (String.Join(",", convertToArray));

        }
    }

}