namespace InterfaceIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Itransportation> vehicles = new List<Itransportation>();
            foreach (var Vehicle in vehicles)
            {
                Vehicle.Drive();
            }
        }
    }
}
