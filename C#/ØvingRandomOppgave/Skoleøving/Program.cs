namespace Skoleøving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Car 1");
            Car car2 = new Car("Car 2");
         

            while (!car1.finnishLine() && !car2.finnishLine())
            {
                car1.move();
                car2.move();
                Console.WriteLine($"{car1.Name}: {car1.distancetravled}m {car2.Name}: {car2.distancetravled}m");
            }

            if (car1.finnishLine())
            {
                Console.WriteLine($"{car1.Name} has reached the finnishLine");
            }
            else
            {
                Console.WriteLine($"{car2.Name} har reached the finnishLine");
            }
        }
    }
}

