using System;

namespace DrawDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //

            Console.Write("please Enter the size of square :");
            int sizeOfSquare = Convert.ToInt32(Console.ReadLine());

            int line;
            int row;

            for (line = 1; line <= sizeOfSquare; line++)
            {
                string result = "";

                for (row = 1; row <= sizeOfSquare; row++)
                {
                    if (line == 1 || line == sizeOfSquare)
                    {
                        result += "%";
                    }
                    else if (row == 1 || row == sizeOfSquare || row == line)
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

