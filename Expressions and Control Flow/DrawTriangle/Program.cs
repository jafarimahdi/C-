using System;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.Write("please Enter your number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            string star = "*";

            while (count < userInput)
            {
                Console.WriteLine(star);
                count++;
                star += "*";
            }

        }
    }
}

