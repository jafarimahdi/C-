using System;
using System.Collections.Generic;

namespace Pirates
{
    public class Ship
    {
        List<Pirate> pirates { get; set; }
        Pirate[] Capitan = new Pirate[1];


        public Ship()
        {
            pirates = new List<Pirate>() { };
        }

        public void fillShip()
        {
            int piratCrew = new Random().Next(1, 114); // get random number for amount of crew in ship
            for (var i = 0; i < piratCrew; i++)
            {
                // add crew to ship
                Pirate newCrew = new Pirate();
                newCrew.intoxicationOfPirate = new Random().Next(1, 5);
                this.pirates.Add(newCrew);

            }

            this.Capitan[0] = new Pirate(); // make a capitan

            Console.WriteLine($"this ship has {pirates.Count} crew and {Capitan.Length} Capitan ");
        }


        public void shipInfo()
        {
            int capitanIntoxication = Capitan[0].intoxicationOfPirate;
            string capitanState = (Capitan[0].stillAlive) ? "Alive" : "Dead";

            int amountOfAlivePirates = 0;

            foreach (Pirate item in pirates)
            {
                if (item.stillAlive)
                {
                    amountOfAlivePirates++;
                }
            }

            Console.WriteLine($"Rum consumed by the Capitan is{capitanIntoxication} and he is {capitanState}");
            Console.WriteLine($"we have still {amountOfAlivePirates} crew alive, in the ship");

        }

        public Ship Battel(Ship enemyShip)
        {
            // each crew from our ship should fight with enemyShips crew ?
            int ourWinner = 0;
            int enemyWinner = 0;
            List<Pirate> listToLoop = (this.pirates.Count < enemyShip.pirates.Count) ? this.pirates : enemyShip.pirates;

            for (int i = 0; i < listToLoop.Count; i++)
            {
                if (pirates[i].Brawl(enemyShip.pirates[i]))
                {
                    ourWinner++;
                }
                else
                {
                    enemyWinner++;
                };
            }

            Console.WriteLine($"{ourWinner} of our crew and {enemyWinner} of enemy crew won the fight");


            // party after viktory 
            List<Pirate> winner = (ourWinner > enemyWinner) ? enemyShip.pirates : this.pirates;
            foreach (Pirate item in winner)
            {
                item.DrinkSomeRum();
            }

            // retrun the winner ship 
            if ((ourWinner > enemyWinner))
            {
                return (Ship)this;
            }
            else
            {
                return (Ship)enemyShip;
            }
        }

    }
}

