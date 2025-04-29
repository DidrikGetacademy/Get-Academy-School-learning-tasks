using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Cat : Pet
    {
        public Cat()
        {
            
        }

        public override void play()
        {
            Console.WriteLine("Plays with mouse");
        }

        public void purr()
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Mjauz");
        }
    }
}
