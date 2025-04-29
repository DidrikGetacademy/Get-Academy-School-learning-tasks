namespace Area_and_circumference
{
   
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(5),
                new Rectangle(4, 11),
                new Square(7)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name} circumference is {shape.GetCircumference()}");
                Console.WriteLine($"{shape.GetType().Name} area is {shape.GetArea()}\n");
            }
        }
    }

}
