using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class Hero : GameCharacter
    {
        public Hero(int health, int stamina) : base(100, 20)
        {
            this.Strength = 20;
        }

        public override void Fight(GameCharacter opponent)
        {
            opponent.looseHealth(this.Strength);
        }
    }
}
