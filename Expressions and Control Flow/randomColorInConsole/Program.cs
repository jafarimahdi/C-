using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace consoleApp_1
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] names = { ".Net", "blezerPages", "blezerAssembly", "rezerPages", "MVC" };
            Random random = new Random();

            // keep the position of the list
            List<StringPosition> list1 = new List<StringPosition>();


            for (int i = 0; i < 10;)
            {
                // choice item in list randomly 
                int index = random.Next(0, names.Length);
                string name = names[index];


                // for changing of the position in console
                int posX = random.Next(1, 20);
                int posY = random.Next(1, 15);

                // check the repetation
                if (!list1.Any(t => (t.PosY == posY) && (t.PosStartX <= posX && posX <= t.PosEndX)))
                {

                    // save positions in the list
                    StringPosition stringPosition = new StringPosition()
                    {
                        Name = name,
                        PosStartX = posX,
                        PosEndX = posX + name.Length - 1,
                        PosY = posY
                    };

                    list1.Add(stringPosition);

                    // random color for the console
                    int colorNumber = random.Next(1, 7);


                    // call the Extantion method we made
                    Console.ForegroundColor = colorNumber.getColor();
                    Console.SetCursorPosition(posX, posY);

                    printString(name);
                    Thread.Sleep(200);
                    i++;
                }
            }

            Console.SetCursorPosition(0, 16);
            foreach (var item in list1)
            {
                Console.WriteLine(item.ToString());
            }
        }


        public static void printString(string name)
        {
            foreach (char ch in name)
            {

                Console.Write(ch);
                Thread.Sleep(100);

            }

        }

    }
}
