using System;
namespace consoleApp_3
{
    static class MyExtentionMethod
    {

        // Make Extantaion Method 
        public static ConsoleColor getColor(this int colorNumber)
        {
            switch (colorNumber)
            {
                case 0:
                    return ConsoleColor.Red;
                case 1:
                    return ConsoleColor.Blue;
                case 2:
                    return ConsoleColor.Gray;
                case 3:
                    return ConsoleColor.Green;
                case 4:
                    return ConsoleColor.Magenta;
                case 5:
                    return ConsoleColor.Yellow;
                default:
                    return ConsoleColor.Cyan;       
            }
        }


    }
}

