﻿using System;

namespace AppendAFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `typo` and assign the value `Chinchill` to it
            // - Write a function called `AppendA()` that gets a string as an input,
            //   appends an 'a' character to its end and returns with a string
            // - Print the result of `AppendA(typo)`

            string typo = "Chinchill";

            Console.WriteLine(appendA(typo));
        }

        public static string appendA(string add)
        {
            return add + "a";
        }
    }
}

