using System;
using System.Collections.Generic;

namespace Pokomon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemonOfAsh = InitializePokemon();

            // Every pokemon has a name and a type.
            // Certain types are effective against others, e.g. water is effective against fire.

            // Ash has a few pokemon.
            // A wild pokemon appeared!

            Pokemon wildPokemon = new Pokemon("Oddish", "grass", "water");

            // Which pokemon should Ash use?

            Console.Write("I choose you, ");
            Console.WriteLine(findEfectivePokemon(pokemonOfAsh, wildPokemon));
        }


        // 1-method 2- return + make new Object form them class

        private static List<Pokemon> InitializePokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon("Bulbasaur", "grass", "water"),
                new Pokemon("Pikachu", "electric", "water"),
                new Pokemon("Charizard", "fire", "grass"),
                new Pokemon("Pidgeot", "flying", "fighting"),
                new Pokemon("Kingler", "water", "fire")
            };
        }


        public static string findEfectivePokemon(List<Pokemon> ashInput, Pokemon enemyPokemon)
        {
            string result = "";
            foreach (var item in ashInput)
            {
                if (item.IsEffectiveAgainst(enemyPokemon))
                {
                    result = item.Name;
                };

            };
            return result;

        }
    }
}

