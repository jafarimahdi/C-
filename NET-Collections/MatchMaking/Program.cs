using System;
using System.Collections.Generic;

namespace MatchMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Claire", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Tom", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // If someone has no pair, he/she should be added to the list on his/her own
            // Expected output: "Eve-Joe", "Ashley-Fred", "Claire-Tom", "Kat-Todd", "Jane-Neef", "Jeff"

            Match(girls, boys);
        }


        private static void Match(List<string> girls, List<string> boys)
        {
            List<string> resultOfMatch = new List<string> { };


            for (var item = 0; item < boys.Count; item++)
            {
                if (item < girls.Count)
                {
                    resultOfMatch.Add($" {girls[item]}-{boys[item]} ");
                }
                else
                {
                    resultOfMatch.Add(boys[item]);
                }

            };

            foreach (var item in resultOfMatch)
            {

                Console.Write(item);
            }
        }
    }
}

