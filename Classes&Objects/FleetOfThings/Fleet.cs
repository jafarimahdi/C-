using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }



        // method for printing out the list
        public void Print()
        {
            foreach (var item in Things)
            {
                if (item.isCompleted())
                {
                    Console.WriteLine($"[x] {item.giveName()}");
                }
                else
                {
                    Console.WriteLine($"[ ] {item.giveName()}");
                }
            }
        }
    }
}

