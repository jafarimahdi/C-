﻿using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg = 79.2;
            double heightInM = 1.83;

            double myBmi = massInKg / (heightInM * heightInM);

            Console.WriteLine(myBmi);
        }
    }
}

