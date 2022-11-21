using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

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


            // 2- Sharpie Set 

            // Reuse your Sharpie class
            // Create SharpieSet class
            // it contains a list of Sharpie, named listOfSharpies
            // it has a method that adds a new Sharpie to the set: Add(sharpie)
            // it has a method that returns the number of usable Sharpies: CountUsable() -> sharpie is usable if it contains ink
            // it has a method that removes all unusable Sharpies: RemoveTrash()

            Sharpie firstSharpie = new Sharpie("Gray", 13);
            Sharpie secSharpie = new Sharpie("white", 19);
            Sharpie thirdSharpie = new Sharpie("black", 10);

            Console.WriteLine(firstSharpie.ReturnInk());
            Console.WriteLine(secSharpie.ReturnInk());
            Console.WriteLine(thirdSharpie.ReturnInk());


            SharpieSet mySharpieSet = new SharpieSet(); // sharpieSet list
            mySharpieSet.AddSharpie(firstSharpie);
            mySharpieSet.AddSharpie(secSharpie);
            mySharpieSet.AddSharpie(thirdSharpie);

            Console.WriteLine(" ################ ");

            Console.WriteLine(mySharpieSet.CountUsable());

            Console.WriteLine(" ################ ");

            Console.WriteLine("----------------");
            firstSharpie.Use();

            secSharpie.Use();
            secSharpie.Use();

            thirdSharpie.Use();
            thirdSharpie.Use();

            Console.WriteLine("----------------");


            mySharpieSet.RemoveSharpies();


            foreach (var item in mySharpieSet.removedSharpies)
            {
                Console.WriteLine(item.color);
            }

        }
    }
}

