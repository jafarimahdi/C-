using System;

namespace DrawChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //

            for (int i = 0; i <= 8; i++)
            {
                string result = "";
                for (int j = 0; j <= 7; j++)
                {
                    if (i % 2 == 0)
                    {
                        result += (j % 2 == 0) ? "%" : " ";
                    }
                    else
                    {
                        result += (j % 2 == 0) ? " " : "%";

                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}

