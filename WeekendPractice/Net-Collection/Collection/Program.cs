using System;
using System.Collections;
using System.Collections.Generic;
//using Internal;

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

            Console.WriteLine("-------------");


            ArrayList hashmamad2 = new ArrayList() { "chicken", "beef", "ghabeli Polo", 1900, 2015 };

            ArrayList test = new ArrayList();
            foreach (var item in hashmamad2)
            {
                Console.WriteLine(item);

                test.Add(item.ToString());
            }

            foreach (var item in test)
            {
                Console.WriteLine("hi " + item.GetType());
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
            Console.WriteLine();

            // ====================================== Generic ==================

            Console.WriteLine("--- List -----");


            // ------------- List --------------------------


            List<string> shopingList = new List<string>();
            shopingList.Add("Bannana");
            shopingList.Add("Orange");
            shopingList.Add("Apple");

            for (int item = 0; item < shopingList.Count; item++)
            {
                Console.WriteLine(item);
            }

            // listA += listB    JS => listA.contact(listB)

            List<string> shopingList2 = new List<string>() { "Rice", "Oil", "Bread" };

            shopingList.Remove("Oil");


            shopingList2.AddRange(shopingList);

            //   AddRange( )
            shopingList2.AddRange(new string[] { "Pomelo", "Passion Fruit" });

            foreach (var item in shopingList2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--- Dictionary -----");


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


            Console.WriteLine("--- Map ----");
            //  -------------------- Map ---------------------

            // var myMap = new Dictionary<int, char> {
            Dictionary<int, char> myMap = new Dictionary<int, char> {

                {97,'a'},
                {98,'b'},
                {99,'c'},
                {65,'A'},
                {66,'B'},
                {67,'C'},
            };

            //Add value D with the key 68
            myMap.Add(68, 'D');

            //Print how many key-value pairs are in the map
            Console.WriteLine(myMap.Count);

            //Print the value that is associated with key 99
            Console.WriteLine(myMap.GetValueOrDefault(99));

            //Remove the key-value pair where with key 97
            myMap.Remove(97);

            //Print whether there is an associated value with key 100 or not // it return value or nothing
            Console.WriteLine(myMap.GetValueOrDefault(100));

            //Remove all the key-value pairs
            myMap.Clear();

        }
    }
}

