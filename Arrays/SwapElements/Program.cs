using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `orders`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `orders`
            string[] orders = { "first", "second", "third" };
            string swap = orders[0];
            orders[0] = orders[2];
            orders[2] = swap;

            foreach (var item in orders)
            {
                Console.WriteLine(item);
            }
        }
    }
}

