using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace ListIntroduction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list('List A') which contains the following values

            List<string> listA = new List<string>() { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };

            //Create a new list('List B') with the values of List A
            List<string> listB = new List<string>();
            listB.AddRange(listA);

            //Print out whether List A contains "Durian" or not
            Console.WriteLine(listA.Contains("Durian"));
            Console.WriteLine();


            // Remove "Durian" from List B
            listB.Remove("Durian");

            Console.WriteLine("------------");

            //Add "Kiwifruit" to List A after the 4th element
            listA.Insert(5, "kivifruit");

            //Compare the size of List A and List B
            Console.WriteLine(listB.Count);
            Console.WriteLine(listA.Count);
            Console.WriteLine();


            bool listSize = listA.Count == listB.Count ? true : false;
            Console.WriteLine(listSize);

            //Get the index of "Avocado" from List A
            Console.WriteLine(listA.IndexOf("Avocado"));

            //Get the index of "Durian" from List B
            Console.WriteLine(listB.IndexOf("Durian"));

            //Add "Passion Fruit" and "Pomelo" to List B in a single statement
            listB.AddRange(new string[] { "Pomelo", "Passion Fruit" });


            //Print out the 3rd element from List A
            Console.WriteLine(listA[2]);

            //Print all elements of List A
            foreach (var item in listA)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //Print all elements of List B
            foreach (var item in listB)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

