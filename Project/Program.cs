using System;
using CarClassLibrary;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine("Car c is as follows:" + c.Make + "" + c.Model + "" + c.Price);

            Console.ReadLine();
        }
    }
}
