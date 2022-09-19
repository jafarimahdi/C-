using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace TelephoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a map with the following key - value pairs:

            var telephoneBook = new Dictionary<string, string>
            {
                {"Wiliam A.Lathan","405-709-1865" },
                {"John K. Miller", "402-247-8568"},
                {"Hortensia E. Foster", "606-481-6467" },
                {"Amanda D. Newland", "319-243-5613"},
                {"Brooke P. Askew", "307-687-2982" }
            };

            //Create an application which prints out the answers to the following questions:

            //What is John K. Miller's phone number?
            Console.WriteLine(telephoneBook.GetValueOrDefault("John K. Miller"));
            //Console.WriteLine(telephoneBook["John K. Miller"]);


            //Whose phone number is 307 - 687 - 2982 ?
            var findKey = telephoneBook.FirstOrDefault(item => item.Value == "307-687-2982").Key;

            Console.WriteLine(findKey);

            //Do we know Chris E.Myers' phone number? (yes/no)
            string knowChris = (telephoneBook.ContainsKey("Chris E.Myers") ? "Yes" : "No");
            Console.WriteLine(knowChris);
        }
    }
}

