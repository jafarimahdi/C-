using System;

namespace MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it

            Console.WriteLine("plase add the amount of the Mile for converting! ");

            double userMile = Convert.ToDouble(Console.ReadLine());
            double convertToKm = userMile * 1.609344;

            Console.WriteLine($"it will be {convertToKm} in Kilometer ");
            Console.ReadKey();
        }
    }
}

