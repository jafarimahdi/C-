using System;
using System.Collections.Generic;

namespace MapIntroduction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a map where the keys are strings and the values are strings with the following initial values

            var simpleMap = new Dictionary<string, string>{

                { "978-1-60309-452-8", "A Letter to Jo" },
                { "978-1-60309-459-7", "Lupus"},
                { "978-1-60309-444-3", "Red Panda and Moon Bear"},
                { "978-1-60309-461-0", "The Lab"}
            };

            //Print all the key-value pairs in the following format

            foreach (var item in simpleMap)
            {

                Console.WriteLine($"{item.Value} (ISBN: {item.Key})");
            }
            Console.WriteLine();

            // Remove the key-value pair with key 978-1-60309-444-3
            simpleMap.Remove("978-1-60309-444-3");

            //Remove the key-value pair with value The Lab
            simpleMap.Remove("Lab");

            //Add the following key-value pairs to the map
            simpleMap.Add("978-1-60309-450-4", "They Called Us Emeny");
            simpleMap.Add("978-1-60309-453-5", "Why Did we Trust Him?");

            // Print whether there is an associated value with key 478-0-61159-424-8 or not
            Console.WriteLine(simpleMap.ContainsKey("478-0-61159-424-8"));
            Console.WriteLine();

            // Print the value associated with key 978-1-60309-453-5
            Console.WriteLine(simpleMap.GetValueOrDefault("978-1-60309-453-5"));

        }

    }
}

