using System;
namespace Pirates
{
    public class Pirate
    {
        public int intoxicationOfPirate = 0;
        public bool stillAlive = true;

        public Pirate()
        {
        }


        public void DrinkSomeRum()
        {
            if (!stillAlive)
            {
                Console.WriteLine("he's dead");
            }
            else
            {
                this.intoxicationOfPirate++;
            }
        }


        public void HowsItGoingMate()
        {
            if (!stillAlive)
            {
                Console.WriteLine("he's dead");
            }
            else
            {

                if (this.intoxicationOfPirate < 4)
                {
                    Console.WriteLine("Pour me anudder!");
                }
                else
                {
                    Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                    this.intoxicationOfPirate = 0;
                }
            }
        }


        public void Brawl(Pirate anotehrPirate)
        {
            // 1- check if the pirat is alive
            if (!stillAlive)
            {
                Console.WriteLine("he's dead");
            }
            else
            {

                // 2- check if the pirate not passed out 
                if ((this.intoxicationOfPirate < 4 && this.intoxicationOfPirate > 0) &&
                    (anotehrPirate.intoxicationOfPirate < 4 && anotehrPirate.intoxicationOfPirate > 0))
                {
                    if (this.intoxicationOfPirate == anotehrPirate.intoxicationOfPirate)
                    {
                        Console.WriteLine("both passed out");
                        this.intoxicationOfPirate = 0;
                        anotehrPirate.intoxicationOfPirate = 0;
                    }
                    // 3- fight start here
                    else if (this.intoxicationOfPirate < anotehrPirate.intoxicationOfPirate)
                    {
                        Console.WriteLine($"our pirate was the winner {this.intoxicationOfPirate} ");
                        Die();
                    }
                    else
                    {
                        Console.WriteLine("the enemy pirate was the winner");
                        Die();
                    }
                }
                else
                {
                    Console.WriteLine("the pirate is passed out and not able to fight ");
                }
            }
        }

        public void Die()
        {
            this.stillAlive = false;
            Console.WriteLine("one person passed a way!!");
        }
    }
}

