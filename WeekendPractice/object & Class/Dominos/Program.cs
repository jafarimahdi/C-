using System;
using System.Collections.Generic;

namespace Dominos
{
    class Program
    {
        static void Main(string[] args)

        {
            var dominoes = InitializeDominoes();

            // we have a list of array[ ] it made from "Domino Class"


            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides

            // Create a function to write the dominous to the console in the following format

            // eg: [2, 4], [4, 3], [3, 5] ...

            order(dominoes);

        }


        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2)); //[ 5, 2 ]
            dominoes.Add(new Domino(4, 6)); //[4 , 6 ]
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }


        public static void order(List<Domino> myDominos)
        {
            var newList = new List<Domino> { };
            newList.Add(myDominos[0]);


            for (int i = 0; i < myDominos.Count; i++)
            {

                for (int j = 0; j < myDominos.Count; j++)
                {
                    if (newList[i].GetValues()[1] == myDominos[j].GetValues()[0])
                    {
                        newList.Add(myDominos[j]);
                    }
                }
            }

            foreach (var item in newList)
            {
                System.Console.WriteLine($"[ {item.GetValues()[0]}, {item.GetValues()[1]}] ");
            }

        }
    }
}

