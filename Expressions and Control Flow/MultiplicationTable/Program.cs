﻿using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for a number and prints the multiplication table with that number
            //
            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150

            Console.WriteLine("please add your number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int counter = 1;

            while (counter <= 10)
            {
                Console.WriteLine($"{counter} * {userInput} = {counter * userInput}");
                counter++;
            }
        }
    }
}

