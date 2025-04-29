using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_circumference
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override double GetCircumference()
        {
            return 2 * (Length + Width);
        }
    }

}
