using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
      abstract class Pet : Animal
    {
        public string Breed { get; set; }

        public string Name { get; set; }    

        public string Owner { get; set; }

        public abstract void play();

        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a noise");
        }
    }
}
