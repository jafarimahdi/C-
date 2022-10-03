using System;
using System.Collections.Generic;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };

            // "Saturn" is missing from the planetList
            // Insert it into the correct position
            // Create a method called "putSaturn()" which has a list parameter and returns
            // the list of planets in the correct order

            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"

            PutSaturn(planetList, "Saturn", 5);
        }

        private static void PutSaturn(List<string> listOfthePlants, string addToList, int index)
        {
            listOfthePlants.Insert(index, addToList);

            foreach (var item in listOfthePlants)
            {
                Console.Write($" {item}");
            }
        }
    }
}

