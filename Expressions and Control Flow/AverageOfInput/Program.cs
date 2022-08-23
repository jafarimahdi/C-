using System;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            int sum = 0;
            int count = 0;

            while (count < 5)
            {
                Console.WriteLine("please Enter your number: ");
                sum += Convert.ToInt32(Console.ReadLine());
                count++;
            }

            double average = sum / 5;
            Console.WriteLine($"The Average of the { sum } is: {average}");
        }
    }
}

