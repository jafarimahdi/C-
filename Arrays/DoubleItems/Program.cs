using System;
using System.Linq;


namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array

            int[] numbers = { 3, 4, 5, 6, 7 };
            int[] numbers1 = numbers;
            int[] allArray = numbers.Concat(numbers1).ToArray();

            foreach (var i in allArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}

