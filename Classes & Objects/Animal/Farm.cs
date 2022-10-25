using System;
using System.Collections.Generic;

namespace Animal
{
    public class Farm
    {
        public List<Animal> listOfAnimal = new List<Animal>() { };
        public int limit = 0;

        public Farm(int _limit)
        {
            limit = _limit;
        }

        public void breed()
        {
            if (listOfAnimal.Count < limit)
            {
                listOfAnimal.Add(new Animal());
            }
            else
            {
                Console.WriteLine("there is not enuaqh place for new animal");
            }
        }

        public void sell()
        {
            Animal readyToSell = listOfAnimal[0];

            foreach (Animal item in listOfAnimal)
            {
                if (item.hunger > readyToSell.hunger)
                {
                    readyToSell = item;
                }
            }

            listOfAnimal.Remove(readyToSell);


        }
    }
}

