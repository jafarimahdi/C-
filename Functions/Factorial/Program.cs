using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `calculateFactorial()`
            //   that returns the factorial of its input

            Console.WriteLine(calculateFactorial(7));

        }


        public static int calculateFactorial(int userInput)
        {
            int fact = 1;

            for (int i = 1; i <= userInput; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}

