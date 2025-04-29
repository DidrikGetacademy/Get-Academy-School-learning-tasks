using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Galtvort
    {
        public List<Character> characters { get; set; }

        public Galtvort()
        {
            characters = new List<Character>()
               {new Character("Harry Potter", "Gryffindor"), 
                new Character("Hermoine Granger", "Gryffindor"),
                new Character("Ron Weasly", "Gryffindor")};

            characters[0].Introduction();

        }
    }
}
