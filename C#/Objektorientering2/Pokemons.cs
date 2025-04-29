using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientering2
{
    internal class Pokemons
    {
        public string Name;
        public int Level;
        public int Health;

        public Pokemons(string name, int health, int level)
        {
            Name = name;
            Level = level;
            Health = health;
        }
    }
}
