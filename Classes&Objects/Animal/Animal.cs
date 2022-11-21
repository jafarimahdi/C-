using System;
namespace Animal
{
    public class Animal
    {
        public int hunger = 50;
        public int thirst = 50;

        public Animal()
        {

        }

        public void eat()
        {
            this.hunger++;
            Console.WriteLine($"the value of the Hunger is now {hunger}");
        }

        public void drink()
        {
            this.thirst++;
            Console.WriteLine($"the value of the thirst is now {thirst}");
        }

        public void play()
        {
            this.hunger--;
            this.thirst--;
            Console.WriteLine($"the value of hunger is: {hunger} and the thirst is: {thirst}");

        }
    }
}

