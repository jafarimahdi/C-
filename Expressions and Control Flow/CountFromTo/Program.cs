using System;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.Write("please Enter your first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("please Enter your second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 >= number2)
            {
                Console.WriteLine("The second number should be bigger! ");
            }
            else
            {
                while (number1 < number2)
                {
                    Console.WriteLine(number1);
                    number1++;
                }
            }
        }
    }
}

