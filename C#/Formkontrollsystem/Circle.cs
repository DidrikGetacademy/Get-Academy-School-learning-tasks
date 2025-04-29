using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    internal class Circle : Form
    {

        public double _radius  { get; }

        public Circle(string name,string color, double radius) 
            : base(name, color)
        {
            _radius = radius;
        }

        public override double BeregnAreal()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
