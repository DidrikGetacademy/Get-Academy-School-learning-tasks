using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class Boss : GameCharacter
    {
        private Random rand;
        public Boss() : base(400, 10)
        {
            rand = new Random();
        }

        public override void Fight(GameCharacter opponent)
        {
            opponent.looseHealth(rand.Next(0,31));
        }
    }
}
