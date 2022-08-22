using System;

namespace TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints a few operations on two numbers: 22 and 13
            int a = 13;
            int b = 22;
            // Print the result of 13 added to 22
            Console.WriteLine(a + b);

            // Print the result of 13 substracted from 22
            Console.WriteLine(a - b);

            // Print the result of 22 multiplied by 13
            Console.WriteLine(a * b);

            // Print the result of 22 divided by 13 (as a decimal fraction)
            Console.WriteLine(a  / b);

            // Print the integer part of 22 divided by 13
            Console.WriteLine(b / a);

            // Print the remainder of 22 divided by 13
            Console.WriteLine(a % b);
        }
    }
}

