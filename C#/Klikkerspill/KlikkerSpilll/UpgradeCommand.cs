using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpilll
{
     class UpgradeCommand : ICommand
    {
        private ClickerGame _game;

        public UpgradeCommand(ClickerGame game)
        {
            _game = game;
        }
        public char Character { get; } = 'K';


        public void Run()
        {
            _game.upgrade();
        }
    }
}
