using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that prints the numbers from 1 to 100
            // but for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”
            // For numbers which are multiples of both three and five print “FizzBuzz”

            int counter = 1;
            while (counter <= 100)
            {
                if ((counter % 3 == 0) && (counter % 5 == 0))
                {
                    Console.WriteLine($"{counter} is: FizzBuzz");
                }
                else if ((counter % 3 == 0))
                {
                    Console.WriteLine($"{counter} is:Fizz");
                }
                else if (counter % 5 == 0)
                {
                    Console.WriteLine($"{counter} is:Buzz");
                }
                counter++;
            }

        }
    }
}

