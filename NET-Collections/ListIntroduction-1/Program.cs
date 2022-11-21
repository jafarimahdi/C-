using System;
using System.Collections.Generic;
using System.Linq;

namespace ListIntroduction_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Console.WriteLine(names.Count());
            names.Add("William");
            Console.WriteLine((!names.Any()) ? true : false);
            names.Add("John");
            names.Add("Amanda");
            Console.WriteLine(names.Count());
            Console.WriteLine(names[2]);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }


            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + names[i]);
            }

            names.RemoveAt(1);
            names.Reverse();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            names.Clear();
            Console.WriteLine(names.Count());

        }
    }
}

