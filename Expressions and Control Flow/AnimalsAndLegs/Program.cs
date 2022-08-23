using System;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.Write("Please Enter the amount of the Chickens: ");
            int chickens = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter the amount of the Pigs: ");
            int pigs = Convert.ToInt32(Console.ReadLine());


            int legs = (chickens * 2) + (pigs * 4);

            Console.WriteLine($"All the legs in the farm are {legs }!");
        }
    }
}

