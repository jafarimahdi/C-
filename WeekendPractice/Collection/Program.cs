using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Collection     1- ArrayList

            //ArrayList hashmamad = new ArrayList(); // Array in Javascript 
            //hashmamad.Add("fish");
            //hashmamad.Add("bolani");
            //hashmamad.Add(29);
            //hashmamad.Add(1.73);

            //foreach (var item in hashmamad)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---------------------------");


            //ArrayList hashmamad2 = new ArrayList() { "chicken", "beef", "ghabeli Polo", 1900, 2015 };

            //ArrayList test = new ArrayList();
            //foreach (var item in hashmamad2)
            //{
            //    Console.WriteLine(item);

            //    test.Add(item.ToString());
            //}

            //foreach (var item in test)
            //{
            //    Console.WriteLine(item.GetType());
            //}


            // ---------- Dictionary  ------------------------

            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries.Add("hungary", "budapst");
            countries.Add("germany", "munich");
            countries.Add("austria", "vienna");

            countries["germany"] = "berlin"; // change the value 

            if (countries.ContainsKey("austria")) // chack by key
            {
                countries.Remove("austria");      // remove by key
            }


            foreach (KeyValuePair<string, string> item in countries) // foreach in Dictionary 
            {
                Console.WriteLine(item);
            }
        }
    }
}

