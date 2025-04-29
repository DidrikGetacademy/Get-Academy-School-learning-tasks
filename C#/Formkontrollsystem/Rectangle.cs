using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    internal class Rectangle : Form
    {
        public double  _width { get; }

        public double _length { get; }
   

        public Rectangle(string name, string color,double width,double length) 
            : base(name, color)
        {
            _width = width;
            _length = length;
        }
        public override double BeregnAreal()
        {
            return _width * _length;
        }
    }
}
