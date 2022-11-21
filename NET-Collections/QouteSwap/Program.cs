using System;
using System.Collections.Generic;

namespace QouteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally, I messed up this quote from Richard Feynman - two words are out of place,
            // Your task is to fix it by swapping the right words in your code
            // To do this, create a method called "SwapQuote()" which takes the `list` as a parameter,
            // fixes the order of the words and returns the words joined in a single string with spaces between them.

            // Expected output: "What I cannot create, I do not understand."
            Console.WriteLine(SwapQuote(list));
        }

        public static string SwapQuote(List<string> list)
        {
            int findDoIndex = list.IndexOf("do");
            int findCannotIndex = list.IndexOf("cannot");

            //swap the element by index
            list[findCannotIndex] = "do";
            list[findDoIndex] = "cannot";

            string result = "";
            foreach (var item in list)
            {
                result += item + " ";
            }
            return result;
        }
    }
}

