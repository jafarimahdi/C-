using System;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Plase enter the first number");
            int firstInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Plase enter the first number");
            int secondInput = Convert.ToInt32(Console.ReadLine());

            int result = (firstInput > secondInput) ? firstInput : secondInput;

            Console.WriteLine($"The bigger number you Enterd is {result}");
        }
    }
}

