using System;

namespace OneTwoAlot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot

            Console.WriteLine("please Enter a Number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            string result;

            if (userInput <= 0)
            {
                result = "Not Enough";
            }
            else if (userInput == 1)
            {
                result = "One";
            }
            else if (userInput == 2)
            {
                result = "Two";
            }
            else
            {
                result = "A lot";

            }

            Console.WriteLine($"{result}");
        }
    }
}

