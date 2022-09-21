using System;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace ProductDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are going to represent our products in a map where the keys are strings representing the product's name and the values are numbers representing the product's price.

            //Create a map with the following key - value pairs:

            //Product name(key)  Price(value)
            //    Eggs    200
            //    Milk    200
            //    Fish    400
            //    Apples  150
            //    Bread   50
            //    Chicken 550
            //Create an application which prints out the answers to the following questions:
            var product = new Dictionary<string, int>()
            {
                {"Eggs",200 },
                {"Milk",200},
                {"Fish",400},
                {"Apples",150},
                {"Bread",50},
                {"Chicken",550}
            };

            //How much is the fish ?
            Console.WriteLine(product.GetValueOrDefault("Fish"));

            //What is the most expensive product?
            int findExpensiveProduct = 0;
            foreach (var item in product)
            {
                if (item.Value > findExpensiveProduct)
                {
                    findExpensiveProduct = item.Value;
                }
            }

            string returnProductKey = product.FirstOrDefault(x => x.Value == findExpensiveProduct).Key;
            Console.WriteLine(returnProductKey);

            //What is the average price?
            int sumOfTheProductItems = 0;
            foreach (var item in product)
            {
                sumOfTheProductItems += item.Value;
            };

            float avregaOfProductItems = sumOfTheProductItems / product.Count();
            Console.WriteLine(avregaOfProductItems);

            //How many products' price is below 300?
            int productBelow300 = 0;

            foreach (var item in product)
            {
                if (item.Value < 300)
                {
                    productBelow300++;
                };
            };

            Console.WriteLine($"Amount of the items, below 300 are: {productBelow300}");

            //Is there anything we can buy for exactly 125 ?
            string productWith125 = product.ContainsValue(125) ? "Yes" : "No";
            Console.WriteLine(productWith125);


            //What is the cheapest product ?      // ! -- you must take the first value and key for start
            int findeCheapestProduct = 0;
            foreach(var item in product)
            {
                if(item.Value < findeCheapestProduct)
                {
                    findeCheapestProduct = item.Value;
                }
            }
            string findTheKeyOfCheapestProduct = product.FirstOrDefault(x => x.Value == findeCheapestProduct).Key;
            Console.WriteLine(findTheKeyOfCheapestProduct);

        }
    }
}

