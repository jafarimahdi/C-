using System;
using System.Collections.Generic;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an Animal class
            //Every animal has a hunger value, which is a whole number
            //Every animal has a thirst value, which is a whole number
            //When creating a new animal instance these values must be set to the default 50 value
            //Every animal can eat() which decreases its hunger by one
            //Every animal can drink() which decreases its thirst by one
            //Every animal can play() which increases both its hunger and thirst by one

            // Farm

            // Reuse your Animal class
            // Create a Farm class
            // it has a list of Animals listOfAnimals
            // it has a limit that defines how many animals can be kept in the Farm and can be set when the Farm is created
            // it has two methods:
            // breed() -> creates a new animal if there's place for it
            // sell() -> removes the least hungry animal


            Animal myCat = new Animal();
            myCat.eat();
            myCat.drink();
            myCat.play();

            Farm firstOne = new Farm(4);

            firstOne.breed();
            firstOne.breed();
            firstOne.breed();
            firstOne.breed();


            foreach (Animal item in firstOne.listOfAnimal)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(firstOne.listOfAnimal.Count);

            firstOne.sell();
            firstOne.sell();
            firstOne.sell();
            firstOne.sell();

            Console.WriteLine(firstOne.listOfAnimal.Count);

            firstOne.breed();

            Console.WriteLine(firstOne.listOfAnimal.Count);
        }
    }
}

