using System;
using System.Collections.Generic;

namespace StudentCounter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentDictionaries = new List<Dictionary<string, object>>();

            // Given this list of dictionaries...

            var student0 = new Dictionary<string, object>();
            student0.Add("name", "Theodor");
            student0.Add("age", 9);
            student0.Add("candies", 2);
            studentDictionaries.Add(student0);

            var student1 = new Dictionary<string, object>();
            student1.Add("name", "Paul");
            student1.Add("age", 10);
            student1.Add("candies", 1);
            studentDictionaries.Add(student1);

            var student2 = new Dictionary<string, object>();
            student2.Add("name", "Mark");
            student2.Add("age", 7);
            student2.Add("candies", 3);
            studentDictionaries.Add(student2);

            var student3 = new Dictionary<string, object>();
            student3.Add("name", "Peter");
            student3.Add("age", 12);
            student3.Add("candies", 5);
            studentDictionaries.Add(student3);

            var student4 = new Dictionary<string, object>();
            student4.Add("name", "Olaf");
            student4.Add("age", 12);
            student4.Add("candies", 7);
            studentDictionaries.Add(student4);

            var student5 = new Dictionary<string, object>();
            student5.Add("name", "George");
            student5.Add("age", 3);
            student5.Add("candies", 2);
            studentDictionaries.Add(student5);

            // Create a function called `ListOfNames()` which takes a list of student dictionaries and returns
            // the names of students (as a list of strings) who have more than 4 candies

            // Expected output: "Peter", "Olaf"
            ListOfNames(studentDictionaries);

            // Create a function called `SumOfAges()` which takes a list of student dictionaries and returns
            // the sum (as an integer) of the ages of students who have less than 5 candies

            // Expected output: 29
            Console.WriteLine(SumOfAges(studentDictionaries));
        }



        public static void ListOfNames(List<Dictionary<string, object>> userInput)
        {
            List<string> namesWithMoreCandies = new List<string>() { };

            foreach (var item in userInput)
            {
                int candies = (int)item.GetValueOrDefault("candies");
                if (candies > 4)
                {
                    namesWithMoreCandies.Add((string)item["name"]);
                };

            }

            foreach (var item in namesWithMoreCandies)
            {
                Console.WriteLine(item);
            }
        }


        public static int SumOfAges(List<Dictionary<string, object>> userInput)
        {
            int ageInTotal = 0;

            foreach (var item in userInput)
            {
                int candies = (int)item.GetValueOrDefault("candies");
                if (candies < 5)
                {
                    ageInTotal += (int)item["age"];
                }
            }

            return ageInTotal;
        }

    }
}

