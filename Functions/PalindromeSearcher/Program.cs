using System;
using System.Collections.Generic;

namespace PalindromeSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function named searchPalindrome() following your current language's style guide.
            //It should take a string, search for palindromes that is at least 3 characters long and return a list with the found palindromes.

            //           input                                             output

            //   "dog goat dad duck doodle never"           ["og go", "g g", " dad ", "dad", "d d", "dood", "eve"]
            //   "apple"                                    []
            //   "racecar"                                  ["racecar", "aceca", "cec"]
            //   ""                                         []

            //Console.WriteLine(searchPalindrome("dog goat dad duck doodle never"));
            Console.WriteLine(searchPalindrome("dog goat"));


        }


        public static string searchPalindrome(string userInput)
        {
            //var result = new List<string> { };
            var result = "";
            int indexCounter = 2;
            int subStart = 0;

            while (indexCounter < userInput.Length)
            {


                string checkWord = userInput.Substring(subStart, indexCounter);



                for (int start = 2; start < userInput.Length; start++)
                {
                    char[] toArray = checkWord.ToCharArray();
                    Array.Reverse(toArray);
                    string resultReversed = String.Join(' ', toArray);

                    if (checkWord == resultReversed)
                    {
                        //result.Add($"{checkWord} {resultReversed}");
                        result += checkWord + " " + resultReversed + ",";
                    }
                }

                indexCounter++;
                subStart++;
            }
            //1. make a loop
            //take the first 3 index
            //2. check if it's palindrome, push to empty array
            // 3. add one more char to the loop and check the word again
            // 4. in each loop it must move one index forthure for start of Substering( ) method

            return result;
        }
    }
}

