using System;
using System.Collections.Generic;

namespace Pirates
{
    public class Ship
    {
        List<Pirate> pirates_list { get; set; }
        Pirate[] Capitan = new Pirate[1];


        public Ship()
        {
            pirates_list = new List<Pirate>() { };
            Capitan = new Pirate[1];

        }

        public void fillShip()
        {
            int pirate_crew = new Random().Next(1, 114); // get random number for amount of crew in ship

            for (var i = 0; i < pirate_crew; i++)
            {
                // add crew to ship
                Pirate newCrew = new Pirate();
                newCrew.intoxication_Of_Pirate = new Random().Next(1, 5);
                this.pirates_list.Add(newCrew);

            }

            this.Capitan[0] = new Pirate(); // make a capitan

            Console.WriteLine($"this ship has {pirates_list.Count} crew and {Capitan.Length} Capitan ");
        }


        public void shipInfo()
        {
            int capitanIntoxication = Capitan[0].intoxication_Of_Pirate;
            string capitanState = (Capitan[0].still_Alive) ? "Alive" : "Dead";

            int amountOfAlivePirates = 0;

            foreach (Pirate item in pirates_list)
            {
                if (item.still_Alive)
                {
                    amountOfAlivePirates++;
                }
            }

            Console.WriteLine($"Rum consumed by the Capitan is{capitanIntoxication} and he is {capitanState}");
            Console.WriteLine($"we have still {amountOfAlivePirates} crew alive, in the ship");

        }


        public Ship Battel(Ship enemyShip)
        {
            // each crew from our ship should fight with enemyShips crew
            int ourWinner = 0;
            int enemyWinner = 0;
            List<Pirate> listToLoop = (this.pirates_list.Count < enemyShip.pirates_list.Count) ? this.pirates_list : enemyShip.pirates_list;

            for (int i = 0; i < listToLoop.Count; i++)
            {
                if (pirates_list[i].Brawl(enemyShip.pirates_list[i]))
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
            List<Pirate> winner = (ourWinner > enemyWinner) ? enemyShip.pirates_list : this.pirates_list;
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

