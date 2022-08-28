using System;

namespace SumAllElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements of `numbers`
            int[] numbers = { 3, 4, 5, 6, 7 };
            int totall = 0;

            foreach (int item in numbers)
            {
                totall += item;
            }
            Console.WriteLine($"the Sum of the items in Array is:{totall}");
        }
    }
}

