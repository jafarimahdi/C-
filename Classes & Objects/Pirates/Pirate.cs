using System;
namespace Pirates
{
    public class Pirate
    {
        public int intoxication_Of_Pirate = 0;
        public bool still_Alive = true;

        public Pirate()
        {
        }

        public void DrinkSomeRum()
        {
            if (!still_Alive)
            {
                Console.WriteLine("he's dead");
            }
            else
            {
                this.intoxication_Of_Pirate++;
            }
        }


        public void HowsItGoingMate()
        {
            if (!still_Alive)
            {
                Console.WriteLine("he's dead");
            }
            else
            {

                if (this.intoxication_Of_Pirate < 4)
                {
                    Console.WriteLine("Pour me anudder!");
                }
                else
                {
                    Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                    this.intoxication_Of_Pirate = 0;
                }
            }
        }


        public bool Brawl(Pirate anotehrPirate)
        {
                                            // 1- check if the pirat is alive
            if (!this.still_Alive || !anotehrPirate.still_Alive)
            {
                Console.WriteLine("Pirat is dead and not able to fight ");
                return false;
            }
            else
            {
                // 2- check if the pirate not passed out 
                if ((this.intoxication_Of_Pirate < 4 && this.intoxication_Of_Pirate > 0) &&
                    (anotehrPirate.intoxication_Of_Pirate < 4 && anotehrPirate.intoxication_Of_Pirate > 0))
                {
                    if (this.intoxication_Of_Pirate == anotehrPirate.intoxication_Of_Pirate)
                    {
                        Console.WriteLine("both passed out");
                        this.intoxication_Of_Pirate = 0;
                        anotehrPirate.intoxication_Of_Pirate = 0;
                        return false;
                    }
                    // 3- fight start here
                    else if (this.intoxication_Of_Pirate < anotehrPirate.intoxication_Of_Pirate)
                    {
                        Console.WriteLine($"our pirate was the winner {this.intoxication_Of_Pirate} ");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("the enemy pirate was the winner");
                        Die();
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("the pirate is passed out and not able to fight ");
                    return true;
                }
            }
        }

        public void Die()
        {
            this.still_Alive = false;
            Console.WriteLine("one person passed a way!!");
        }
    }
}

