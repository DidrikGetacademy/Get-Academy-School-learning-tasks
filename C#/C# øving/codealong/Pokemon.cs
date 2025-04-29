using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codealong
{
   public class Pokemon
    {

        private string Name { get; set; }

        private int Health { get; set; }

        private int Damage { get; set; }

        Random rand = new Random();
        private List<Pokemon> Pokemons { get; set; }
        public Pokemon(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Pokemons = new List<Pokemon>();
        }

        public Pokemon()
        {
            Pokemons = new List<Pokemon>();
            addpokemon();
        }


        public List<Pokemon> poke()
        {
            return Pokemons;
        }
        public string NameOfPokemon()
        {
            return Name;
        }

        public int healthofPokemon()
        {
            return Health;
        }

        public int DamageOfpokemon()
        {
            return Damage;
        }

        void addpokemon()
        {
            var randomDamage = rand.Next(0, 50);
            var pokemon1 = new Pokemon("Pikachu", 100, randomDamage);
            var pokemon2 = new Pokemon("Balbasaur", 100, randomDamage);
            var pokemon3 = new Pokemon("charmelon", 100, randomDamage);
            var pokemon4 = new Pokemon("evee", 100, randomDamage);
            Pokemons.Add(pokemon1);
            Pokemons.Add(pokemon2);
            Pokemons.Add(pokemon3);
            Pokemons.Add(pokemon4);
        }


      public  void printPokemons()
        {
            addpokemon();
            foreach (var pokemon in Pokemons)
            {
                Console.WriteLine($"Name:{pokemon.Name}," + $" Health:{pokemon.Health}" +  $" Damage:{pokemon.Damage}");
            }
        }

     
    }
}
