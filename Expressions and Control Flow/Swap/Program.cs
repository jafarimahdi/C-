﻿using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            int template;
            template = a;
            a = b;
            b = template;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}

