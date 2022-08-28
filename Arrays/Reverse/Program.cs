using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements of `numbers`
            int[] numbers = { 3, 4, 5, 6, 7 };
            Array.Reverse(numbers);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

