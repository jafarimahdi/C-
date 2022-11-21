using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace TodoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the `todoText`
            // Add " - Download games" to the end of the `todoText`
            // Add " - Diablo" to the end of the `todoText` applying indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            //StringBuilder convertToDo = new StringBuilder(todoText);

            string result = todoText.Insert(0, "My todo:\n");
            result += " - Download games\n";
            result += "     - Diablo ";

            Console.WriteLine(result);


        }
    }
}

