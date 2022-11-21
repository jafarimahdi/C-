using System;
using System.Collections.Generic;

namespace Pirates
{
    public class BattelApp
    {
        public List<Ship> listOfShip;

        public BattelApp()
        {
            listOfShip = new List<Ship>();
        }

        public void addShip(Ship newShip)
        {
            listOfShip.Add(newShip);
        }

        public void battelShips(BattelApp anotherBattel)
        {
            for (int i = 0; i < listOfShip.Count; i++)
            {
                listOfShip[i].Battel(anotherBattel.listOfShip[i]); 
            }
        }


    }
}

