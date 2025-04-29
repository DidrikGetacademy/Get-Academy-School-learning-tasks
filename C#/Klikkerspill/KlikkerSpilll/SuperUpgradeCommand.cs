using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpilll
{
    internal class SuperUpgradeCommand : ICommand
    {
        private ClickerGame _game;

        public SuperUpgradeCommand(ClickerGame game)
        {
            _game = game;
        }
        public char Character { get; } = 'S';
        public void Run()
        {
            _game.superUpgrade();
        }
    }
}
