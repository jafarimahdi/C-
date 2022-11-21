using System;
using System.Collections.Generic;

namespace AppendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<string> {
                "koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill",
                "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn"
            };

            // Create a method called AppendA() that adds "a" to every string in the "animals" list
            // The method should accept a list of strings as a parameter and return an updated list of strings
            // Expected output: "koala", "panda", "zebra", "anaconda", "boa", "chinchilla", "cobra", "gorilla", "hyena", "hydra", "iguana", "impala", "puma", "tarantula", "pirahna"

            AppendA(animals);

        }

        public static void AppendA(List<string> animals)
        {
            foreach (string item in animals)
            {
                Console.Write(item + "a  ");

            }
        }
    }
}

