using System;
using System.Collections.Generic;

namespace practice
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
            personPaymant(product, bobShoppingList);

            //   How much does Alice pay ?
            personPaymant(product, aliceShoppingList);

            //   Who buys more Rice?
            moreStuff(aliceShoppingList, bobShoppingList, "Rice");

            //   Who buys more Potato?
            moreStuff(aliceShoppingList, bobShoppingList, "Potato");

            //   Who buys more Ham?
            moreStuff(aliceShoppingList, bobShoppingList, "Ham");

            //   Who buys more Apples?
            moreStuff(aliceShoppingList, bobShoppingList, "Apples");

            //Who buys more of different products?
            whoBuyMoreProduct(aliceShoppingList, bobShoppingList);

            //Who buys more items? (more pieces)
            whoBuysMoreitems(aliceShoppingList, bobShoppingList);


        }


        public static void personPaymant(Dictionary<string, Double> productList, Dictionary<string, int> personList)
        {
            Double PersonHasToPay = 0;

            foreach (var item in personList)
            {
                if (productList.ContainsKey(item.Key))
                {

                    var addToPersonPaymant = item.Value * productList[item.Key];

                    Console.WriteLine($"{item.Value} * {productList[item.Key]}");

                    PersonHasToPay += addToPersonPaymant;
                }
            }
            Console.WriteLine($"This person has to pay:{PersonHasToPay}");
            Console.WriteLine("-------");
        }






        private static void moreStuff(Dictionary<string, int> aliceList, Dictionary<string, int> bobList, string stuff)
        {
            if (!(aliceList.ContainsKey(stuff) || bobList.ContainsKey(stuff)) || (aliceList.GetValueOrDefault(stuff) == bobList.GetValueOrDefault(stuff)))
            {
                Console.WriteLine("no One");
            }
            else
            {
                string whoBuyMoreStuff = (aliceList.GetValueOrDefault(stuff) > bobList.GetValueOrDefault(stuff)) ? "Alice" : "Bob";
                Console.WriteLine(whoBuyMoreStuff);
            }
        }


        private static void whoBuyMoreProduct(Dictionary<string, int> aliceList, Dictionary<string, int> bobList)
        {
            string whoBuyMore = (aliceList.Count > bobList.Count) ? "Alice" : "Bob";
            Console.WriteLine(whoBuyMore);
        }



        private static void whoBuysMoreitems(Dictionary<string, int> aliceList, Dictionary<string, int> bobList)
        {
            int aliceItems = 0;
            foreach (var item in aliceList)
            {
                aliceItems += item.Value;

            }

            int bobItems = 0;
            foreach (var item in bobList)
            {
                bobItems += item.Value;

            }

            string aliceBuysMoreOrBob = (aliceItems > bobItems) ? "Alice" : "Bob";
            Console.WriteLine(aliceBuysMoreOrBob);
        }

    }
}

