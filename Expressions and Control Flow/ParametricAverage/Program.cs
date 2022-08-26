using System;

namespace ParametricAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number
            // It would ask this many times to enter an integer
            // If all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4


            bool keepRun = true;
            int sum = 0;
            int count = 0;

            float avreage;

            while (keepRun)
            {

                Console.Write(" Plese enter a Number: ");
                int userInput;
                bool correctInput = int.TryParse(Console.ReadLine(), out userInput);

                sum += userInput;
                count++;

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    keepRun = false;
                    avreage = (float)sum / count;

                    Console.WriteLine(" you touched the Esc key");
                    Console.WriteLine($" sum:{sum} and you Enterd {count} times number, so Avreage will be: {avreage} ");
                }

            }
        }
    }
}

