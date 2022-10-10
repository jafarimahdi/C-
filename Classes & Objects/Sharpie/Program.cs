using System;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Sharpie class
            //  We should know the followings about each sharpie:
            //  color(which should be a string),
            //  width(which will be a number) and the
            //  inkAmount(another number)

            //We need to specify the color and the width at creation
            //Every sharpie is created with a default inkAmount value: 100
            //We can Use() the sharpie objects: using it decreases inkAmount by 10

            Sharpie firstSharpie = new Sharpie("Gray", 13);
            firstSharpie.Use();


        }
    }
}

