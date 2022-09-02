using System;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes an array of numbers as parameter
            //  and returns an array where the elements are sorted in ascending numerical order
            //  When you are done, add a second boolean parameter to the function
            //  If it is `true` sort the array descending, otherwise ascending


            //  Example:
            //Console.WriteLine(Bubble(new int[] { 34, 12, 24, 9, 5 }));
            //  should print [5, 9, 12, 24, 34]

            var firstFunc = Bubble(new int[] { 34, 12, 24, 9, 5 });
            foreach (var item in firstFunc)
            {
                Console.Write(item + " ");
            };


            Console.WriteLine();


            //Console.WriteLine(AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true));
            //  should print [34, 24, 12, 9, 5]

            var secFunc = AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true);
            foreach (var item in secFunc)
            {
                Console.Write(item + " ");
            };
        }

        public static Array Bubble(int[] userInput)
        {
            Array.Sort(userInput);

            return userInput;
        }


        public static Array AdvancedBubble(int[] userInput, bool userComment)
        {
            Array.Sort(userInput);
            if (userComment)
            {
                Array.Reverse(userInput);
                return userInput;
            }

            return userInput;
        }

    }
}

