using System;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace PersonalFinance
{
    class Program
    {
        static void Main(string[] args)
        {

            // We are going to represent our expenses in a list containing integers:

            //Create a list with the following items:
            //500, 1000, 1250, 175, 800 and 120

            List<int> personalFinance = new List<int>(){
                500, 1000, 1250, 175, 800,120
            };

            //Create an application which prints out the answers to the following questions:
            //How much did we spend?

            int allToghether = 0;
            foreach (int item in personalFinance)
            {
                allToghether += item;
            };
            Console.WriteLine(allToghether);

            //Which was our greatest expense?

            personalFinance.Sort();

            int expensiveItem = personalFinance[personalFinance.Count - 1];
            Console.WriteLine(expensiveItem);

            //Which was our cheapest spending?
            int cheapestItem = personalFinance[0];
            Console.WriteLine(cheapestItem);


            //What was the average amount of our spendings ? (print this as a float value)

            float avreage = allToghether / personalFinance.Count;
            Console.WriteLine(avreage);

        }
    }
}

