using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientering
{
     class Box
     {
         public int Width;
         public int Height;


         public void Show()
         {
            Console.WriteLine("bredden er " + Width + " og høyden er " + Height);
         }
     }
}
