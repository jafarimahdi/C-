using System;

namespace oddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // then prints "Odd" if the number is odd, or "Even" if it is even.

            Console.WriteLine("please Eneter a Number:");
            int userInput = Convert.ToInt32(Console.ReadLine());


            string oddEven = ((userInput % 2) == 0) ? "Even" : "Odd";

            Console.WriteLine($"Your Number is {oddEven}");
        }
    }
}

