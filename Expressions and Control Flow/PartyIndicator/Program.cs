using System;

namespace PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second represents the number of boys
            //
            // If the the number of girls and boys are equal and 20 or more people are coming to the party
            // it should print: The party is excellent!
            //
            // If there are 20 or more people coming to the party but the girl - boy ratio is not 1-1
            // it should print: Quite a cool party!
            //
            // If there are less people coming than 20
            // it should print: Average party...
            //
            // If no girls are coming, regardless the count of the people
            // it should print: Sausage party

            Console.WriteLine("please enter the number of girls:");
            int girls = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please enter the number of boys:");
            int boys = Convert.ToInt32(Console.ReadLine());

            int allTheBoysAndGirls = boys + girls;

            string partySituation;

            if (girls == 0)
            {
                partySituation = "Sausage Party";
            }
            else if ((girls == boys) && (allTheBoysAndGirls >= 20))
            {
                partySituation = "The Party is excellent !";
            }
            else if (allTheBoysAndGirls >= 20)
            {
                partySituation = "Quite a cool party!";
            }
            else
            {
                partySituation = "it's Average party";
            }

            Console.WriteLine(partySituation);
        }
    }
}

