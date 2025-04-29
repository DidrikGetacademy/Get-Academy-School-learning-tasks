using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpilll
{
    class ClickerGame
    {

         public int _points { get; set; } = 0;

         private int _pointsPerClick = 1;

         private int _pointsPerClickIncreace = 1;

         public void click()
         {
             _points += _pointsPerClick;
         }

         public void upgrade()
         {
             if (_points < 10) return;
             
                 _points -= 10;
                 _pointsPerClick += _pointsPerClickIncreace;
         }

         public void superUpgrade()
         {
             if (_points < 100) return;
             _points -= 100;
             _pointsPerClick += _pointsPerClickIncreace++;
         }
    }
}
