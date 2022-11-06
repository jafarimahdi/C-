using System;
namespace Pirates
{
    public class BattelApp
    {
        public BattelApp()
        {
        }

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

