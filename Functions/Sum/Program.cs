﻿using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function called `sum()` that returns the sum of numbers from zero to the given parameter

            Console.WriteLine(sum(10));

        }
        public static int sum(int userInpt)
        {
            int sumNumbers = 0;

            for (int i = 0; i <= userInpt; i++)
            {
                sumNumbers += i;
            }
            return sumNumbers;

        }
    }
}

