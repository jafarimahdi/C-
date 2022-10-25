using System;
namespace Sharpie
{
    public class Sharpie
    {
        public string color = "";
        public int with = 0;
        public int inkAmount = 20;


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

        public int ReturnInk()
        {
            return inkAmount;
        }
    }
}

