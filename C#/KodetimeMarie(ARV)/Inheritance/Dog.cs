using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Dog : Pet
    {

        public void Bark()
        {

        }

        public void ChewOnSofa()
        {

        }

        public void GoForWalk()
        {

        }
        public override void play()
        {
            Console.WriteLine("Play with ball");
        }
    }
}
