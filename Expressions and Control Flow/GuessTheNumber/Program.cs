using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number and the user has to figure it out
            // The user can input guesses
            // After each guess the program would tell one of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            bool keepRun = true;

            while (keepRun)
            {
                int mainNumber = 13;

                Console.Write("Plese enter your Number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());


                if (userInput > mainNumber)
                {
                    Console.WriteLine("The stored number is Lower");
                }
                else if (userInput < mainNumber)
                {
                    Console.WriteLine("The stored number is Higher ");
                }
                else
                {
                    Console.WriteLine("You found the Right number");
                    keepRun = false;
                }

            }
        }
    }
}

