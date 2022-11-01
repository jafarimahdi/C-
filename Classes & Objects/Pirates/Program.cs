using System;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pirate hajMamad = new Pirate();
            //hajMamad.DrinkSomeRum();
            //hajMamad.DrinkSomeRum();
            //hajMamad.DrinkSomeRum();
            //Console.WriteLine(hajMamad.intoxicationOfPirate);

            //Pirate enemy = new Pirate();

            //Console.WriteLine(enemy.intoxicationOfPirate);

            //Console.WriteLine("-------");
            //hajMamad.Brawl(enemy);

            Ship firestShip = new Ship();

            firestShip.fillShip();
            firestShip.shipInfo();
            Console.WriteLine("-------");

            Ship secoundShip = new Ship();
            secoundShip.fillShip();
            secoundShip.shipInfo();

            Console.WriteLine("-------");

            firestShip.Battel(secoundShip).shipInfo();
        }
    }
}

