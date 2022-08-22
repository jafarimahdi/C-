// See https://aka.ms/new-console-template for more information
using System.Threading;

class Program{

    static void Main (String [] args)
    {

        string[] names = { "mamal", "mahdi", "ali", "safdar", "ghanbar" };

        for (int i = 0; i < 10; i++)
        {
            Random random = new Random();
            int index = random.Next(0, names.Length);
            string name = names[index];
            Console.WriteLine(name);
            Thread.Sleep(200);
        }

    }


}
