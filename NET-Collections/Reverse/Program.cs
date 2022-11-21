using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a string which is passed as q parameter
            // Pass the `toBeReversed` variable to this method to check if it works well
            // At first, solve this task using the `String.Chars[Int32]` property, e.g. `toBeReversed[0]`
            // Try other solutions when you are done

            Console.WriteLine(Reverse(toBeReversed));
        }

        public static string Reverse(string userInput)
        {
            char[] convert = userInput.ToCharArray();
            Array.Reverse(convert);

            string result = String.Join("", convert);

            return result;
        }
    }
}

