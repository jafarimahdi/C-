using System;
using System.Text;
//using System.Collections.Generic;

namespace TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it!
            // Insert the words "always takes longer than" between the words "It" and "you"
            // using the StringBuilder class!

            StringBuilder myQuote = new StringBuilder(quote);
            int startIndex = quote.IndexOf("you");
            string sentence = "always takes longer than ";


            //string addSentences = myQuote.Insert(startIndex, sentence); // ERROR: can't change to string after StringBuilder 
            //Console.WriteLine(addSentences);

            myQuote.Insert(startIndex, sentence);

            Console.WriteLine(myQuote);
        }
    }
}

