using System;
using static System.Net.Mime.MediaTypeNames;

namespace PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a PostIt a struct that has
            //a BackgroundColor
            //a Text on it
            //a TextColor

            //Create a few example post-it objects:
            //an orange with blue text: "Idea 1"
            //a pink with black text: "Awesome"
            //a yellow with green text: "Superb!"


            Post idea = new Post("Orange", "Idea", "blue");
            Console.WriteLine(idea.backgrandColor);
            Console.WriteLine(idea.text);
            Console.WriteLine(idea.textColor);
            Console.WriteLine("--------");

            Post awesome = new Post("pink", "Awsome", "black");
            Console.WriteLine(awesome.backgrandColor);
            Console.WriteLine(awesome.text);
            Console.WriteLine(awesome.textColor);
            Console.WriteLine("--------");



            Post superb = new Post("yellow", "Superb!", "green");
            Console.WriteLine(superb.backgrandColor);
            Console.WriteLine(superb.text);
            Console.WriteLine(superb.textColor);

        }
    }
}

