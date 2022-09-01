using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function named isAnagram() following your current language's style guide.
            //It should take two strings and return a boolean value depending on whether it's an anagram or not.

            Console.WriteLine(isAnagram("mahdi", "idham"));
            Console.WriteLine(isAnagram("google", "google"));
            Console.WriteLine(isAnagram("dog", "god"));

        }
        public static bool isAnagram(string firstW, string secondW)
        {
            char[] convert = secondW.ToCharArray();
            Array.Reverse(convert);
            string result = String.Join("", convert);

            return (result == firstW) ? true : false;
        }
    }
}

