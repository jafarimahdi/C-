using System;

namespace DrawDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //


            Console.WriteLine("Please Enter half of the height ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int space, star;

            for (space = 0; space <= userInput; space++)
            {
                for (star = 1; star <= userInput - space; star++)
                    Console.Write(" ");
                for (star = 1; star <= 2 * space - 1; star++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (space = userInput - 1; space >= 1; space--)
            {
                for (star = 1; star <= userInput - space; star++)
                    Console.Write(" ");
                for (star = 1; star <= 2 * space - 1; star++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
