using System;
namespace Sharpie
{
    public class Sharpie
    {
        string color = "";
        int with = 0;
        int inkAmount = 100;


        public Sharpie(string _color, int _with)
        {
            color = _color;
            with = _with;
        }

        public void Use()
        {
            inkAmount -= 10;
            Console.WriteLine($"the amount of InkAmount is {inkAmount} now.");
        }
    }
}

