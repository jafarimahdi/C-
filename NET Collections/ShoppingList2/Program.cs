using System;
using System.Collections.Generic;

namespace ShoppingList2
{
    class Program
    {

        static void Main(string[] args)
        {
            var product = new Dictionary<string, Double>
            {
                {"Milk",1.07 },
                {"Rice",1.59 },
                {"Eggs",3.14 },
                {"Cheese",12.60 },
                {"Chicken Breasts",9.40 },
                {"Apples",2.31 },
                {"Tomato",2.58 },
                {"Potato", 1.75 },
                {"Onion",1.10 }
            };

            var bobShoppingList = new Dictionary<string, int>
            {
                {"Milk",3 },
                {"Rice",2 },
                {"Eggs",2 },
                {"Cheese",1 },
                {"Chicken Breasts",4 },
                {"Apples",1 },
                {"Tomato",2 },
                {"Potato",1 }
            };

            var aliceShoppingList = new Dictionary<string, int>
            {
                {"Rice",1 },
                {"Eggs",5 },
                {"Chicken Breasts",2 },
                {"Apples",1 },
                {"Tomato", 10 }
            };

            //   How much does Bob pay?
            bobPayment(product, bobShoppingList);
            //How much does Alice pay ?
            alicePayment(product, aliceShoppingList);
            //Who buys more Rice?
            moreRice(aliceShoppingList, bobShoppingList);
            //Who buys more Potato?
            morePotato(aliceShoppingList, bobShoppingList);


        } // end of the main


        public static void bobPayment(Dictionary<string, Double> productList, Dictionary<string, int> bobList)
        {
            Double bobHasToPay = 0;

            foreach (var item in bobList)
            {
                if (productList.ContainsKey(item.Key))
                {

                    var addToBobPaymant = item.Value * productList[item.Key];

                    Console.WriteLine($"{item.Value} * {productList[item.Key]}");

                    bobHasToPay += addToBobPaymant;
                }
            }
            Console.WriteLine($"For the Shopping Bob has to pay:{bobHasToPay}");
            Console.WriteLine("-------");
        }

        private static void alicePayment(Dictionary<string, double> productList, Dictionary<string, int> aliceList)
        {
            Double aliceHasToPay = 0;

            foreach (var item in aliceList)
            {
                if (productList.ContainsKey(item.Key))
                {
                    double addToAlicePayment = item.Value * productList[item.Key];

                    Console.WriteLine($"{item.Value} * {productList[item.Key]}");
                    aliceHasToPay += addToAlicePayment;
                }
            }
            Console.WriteLine($"For the Shopping Bob has to pay:{aliceHasToPay}");
            Console.WriteLine("-------");

        }

        private static void moreRice(Dictionary<string, int> aliceList, Dictionary<string, int> bobList)
        {
            string whoBuyMoreRice = (aliceList["Rice"] > bobList["Rice"]) ? "Alice" : "Bob";
            Console.WriteLine(whoBuyMoreRice);
        }

        private static void morePotato(Dictionary<string, int> aliceList, Dictionary<string, int> bobList)
        {
            string whoBuyMorePotato = (aliceList.GetValueOrDefault("Potato") > bobList.GetValueOrDefault("Potato")) ? "Alice" : "Bob";
            Console.WriteLine(whoBuyMorePotato);

        }


    } // end of the class


}

