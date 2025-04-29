using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_circumference
{
    using System;

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }

}
