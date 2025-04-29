using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    internal class Triangle : Form
    {
        public double _base { get; }

        public double _height { get; }


        public Triangle(string name, string color, double BaseLength, double height) : base(name, color)
        {
            _base = BaseLength;
            _height = height;
        }
        public override double BeregnAreal()
        {
            return 0.5 * _base * _height;
        }

      
    }
}
