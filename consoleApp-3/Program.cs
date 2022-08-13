using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace consoleApp_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { ".Net", "blazarPages", "blezerAssembly", "rezerPages", "MVC"};
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                // choice item in list randomly 
                int index = random.Next(0, names.Length);
                string name = names[index];

                // for changing of the position in console
                int posX = random.Next(1, 20);
                int posY = random.Next(1, 15);
                Console.SetCursorPosition(posX, posY);

                // random color for the console
                int colorNumber = random.Next(1, 7);

                // call the Extantion method we made
                Console.ForegroundColor = colorNumber.getColor();

                Console.WriteLine(name);
                Thread.Sleep(200);
            }
        }
    }
}
