using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Xml.Linq;

namespace productDatabase2
{
    class Program
    {
        static void Main(string[] args)
        {
            var product2 = new Dictionary<string, int>
            {
                {"Eggs",200 },
                {"Milk",200 },
                {"Fish",400 },
                {"Apples",150 },
                {"Brad", 50 },
                {"Chicken",550 }
            };

            //Create an application which prints out the answers to the following questions:

            //Which products cost less than 201 ? (just the name)
            foreach (var item in product2)
            {
                if (item.Value < 201)
                {
                    Console.WriteLine(item.Key);
                }
            }
            //Which products cost more than 150 ? (name + price)
            foreach (var item in product2)
            {
                if (item.Value > 150)
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");
                }
            }
        }
    }
}

