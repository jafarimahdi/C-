﻿using System;
using System.Collections.Generic;
using Dominos;

namespace Dominoes
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            OrderedDominoes(dominoes);
            Console.ReadLine();
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;

        }


        public static void OrderedDominoes(List<Domino> dominoes)
        {
            var dominoesNewOrder = new List<Domino>(); // new list

            dominoesNewOrder.Add(dominoes[0]); // first target to compare 



            for (int i = 0; i < dominoes.Count; i++) // loop -1
            {
                for (int j = 0; j < dominoes.Count; j++) // loop -2
                {
                    if (dominoesNewOrder[i].GetValues()[1] == dominoes[j].GetValues()[0])  // compare both loop
                    {
                        dominoesNewOrder.Add(dominoes[j]);
                    }
                }
            }



            foreach (var item in dominoesNewOrder)
            {
                Console.Write(item.ToString());

            }
        }
    }
}