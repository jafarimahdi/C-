using System;
using Microsoft.VisualBasic;
using System.Threading;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are going to represent a shopping list by a list containing strings.

            //Create a list with the following items:
            //eggs, milk, fish, apples, bread and chicken
            //Create an application which prints out the answers to the following questions:
            //Do we have milk in the shopping list ? (yes / no)
            //Do we have bananas in the shopping list ? (yes / no)

            List<string> shoppingList = new List<string>()
            {
                "eggs","milk","fish","apples","bread", "chicken"
            };

            string checkMilk = (shoppingList.Contains("milk")) ? "yes" : "no";
            Console.WriteLine(checkMilk);

            string checkBananas = (shoppingList.Contains("bananas")) ? "yes" : "no";
            Console.WriteLine(checkBananas);
        }
    }
}

