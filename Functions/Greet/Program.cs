using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Budapest` to it
            // - Create a function called `Greet()` that greets its input parameter
            //     - It prints a greeting message e.g. `Greetings Budapest `
            // - Greet `al`

            string al = "Budapest";

            greet(al);
        }

        public static void greet(string name)
        {
            Console.WriteLine($"Greeting from {name}");
        }
    }
}

