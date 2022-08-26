using System;

namespace DrawSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
            // %%%%%%
            //
            // The square should have as many lines as the number was

            Console.Write("please Enter the size of square :");
            int sizeOfSquare = Convert.ToInt32(Console.ReadLine());

            int line;

            for (line = 1; line <= sizeOfSquare; line++)
            {
                string result = "%";

                for (var row = 1; row <= sizeOfSquare; row++)
                {
                    if (line == 1 || line == sizeOfSquare)
                    {
                        result += "%";
                    }
                    else if (row == sizeOfSquare)
                    {
                        result += "%";
                    }
                    else
                    {
                        result += " ";

                    }
                }
                Console.WriteLine(result);
                result = "%";
            }

        }
    }
}

