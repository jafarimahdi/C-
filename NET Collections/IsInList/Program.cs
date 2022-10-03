using System;
using System.Collections.Generic;

namespace IsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Write a method called `CheckNumbers` (with a list of numbers as a parameter), which will return `true`
            // if the list `numbers` contains all the following elements: 4, 8, 12, 16; `false` otherwise.

            // The output should be "true"
            Console.WriteLine(CheckNumbers(numbers));

            // Bonus: write a method called `CheckAllNumbers` with 2 lists as parameters, which will return `true`
            // if the first list contains all the elements of the second list; `false` otherwise.
            var haystack = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21 };
            var needles = new List<int> { 1, 3, 13 };

            // The output should be "true"
            Console.WriteLine(CheckAllNumbers(haystack, needles));
        }

        public static bool CheckNumbers(List<int> numbers)
        {
            List<int> checkList = new List<int> { 4, 8, 12, 16 };
            bool result = true;

            foreach (int item in checkList)
            {
                if (!numbers.Contains(item))
                {
                    result = false;
                }
            }
            return result;
        }

        public static bool CheckAllNumbers(List<int> haystack, List<int> needles)
        {
            bool result = true;
            foreach (int item in needles)
            {
                if (!haystack.Contains(item))
                {
                    result = false;
                }
            }
            return result;
        }
    }
}

