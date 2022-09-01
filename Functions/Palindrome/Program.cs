using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(palindrome("mahdi"));
            Console.WriteLine(palindrome("12345"));
            Console.WriteLine(palindrome("Budapest"));

        }

        public static string palindrome(string userWord)
        {
            char[] convert = userWord.ToCharArray();
            Array.Reverse(convert);
            string result = String.Join("", convert);

            return (userWord + result);
        }
    }
}

