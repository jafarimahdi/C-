using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------- ArrayList  --------------------

            ArrayList hashmamad = new ArrayList(); // Array in Javascript 
            hashmamad.Add("fish");
            hashmamad.Add("bolani");
            hashmamad.Add(29);
            hashmamad.Add(1.73);

            foreach (var item in hashmamad)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");


            ArrayList hashmamad2 = new ArrayList() { "chicken", "beef", "ghabeli Polo", 1900, 2015 };

            ArrayList test = new ArrayList();
            foreach (var item in hashmamad2)
            {
                Console.WriteLine(item);

                test.Add(item.ToString());
            }

            foreach (var item in test)
            {
                Console.WriteLine(item.GetType());
            }


            // ------------- HashTable -------------------

            Hashtable myHashtable = new Hashtable();     // 1- defined the Hashtable
            myHashtable.Add(1, "one");
            myHashtable.Add("name", "Mahdi");           // key and value can be any dataType 


            Hashtable myHashtable2 = new Hashtable() {       // 2- defined the Hashtable as object initializer 
                { 1, "one" },
                { "name", "Mahdi" }
            };

            foreach (var item in myHashtable.Keys)
            {
                Console.Write(item);
            }

            foreach (var item in myHashtable2.Values)
            {
                Console.Write(item);
            }

            // ====================================== Generic ==================



            // ------------- List --------------------------


            List<string> shopingList = new List<string>();
            shopingList.Add("Bannana");
            shopingList.Add("Orange");
            shopingList.Add("Apple");

            for (int item = 0; item < shopingList.Count; item++)
            {
                Console.WriteLine(item);
            }


            List<string> shopingList2 = new List<string>() { "Rice", "Oil", "Bread" };

            shopingList.Remove("Oil");

            foreach (var item in shopingList2)
            {
                Console.WriteLine(item);
            }

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

