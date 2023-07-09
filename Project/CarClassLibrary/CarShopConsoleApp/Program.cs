using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine("Car c is as follows" + c.Make + " "+c.Model + " " + c.Price  );
            Console.ReadLine();

        }
    }
}
