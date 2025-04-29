namespace CodealongØvelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Ferrari");
            var car2 = new Car("Tesla");

            while (!car1.FinnishLine() && !car2.FinnishLine())
            {
                car1.Move();
                car2.Move();
                Console.WriteLine($"{car1.Name} {car1.distanceTravled}, {car2.Name} {car2.distanceTravled}");
            }

            if (car1.FinnishLine())
            {
                Console.WriteLine($"{car1} has reached the finnish line");
            }
            else
            {
                Console.WriteLine($"{car2}, har reached the finnish line");
            }
        }
    }
}



/*
 Car race

Bilen har en start-hastighet på 10m/s ( en iterasjon i en løkke er et sekund).
Bilen skal øke farten med 10m/s frem til den har kjørt 500m,
også skal den senke farten med 10m/s igjen frem til den når minimumshastigheten sin på 10m/s. 
Når bilen har kommet seg til slutt-målet printes det ut til skjermen at bilen er fremme og har parkert.

Utvid oppgaven til at du kan lage 2 biler som kjører om kapp i en løkke, 
der de har en metode som genererer en random hastighet til dem mellom 60-200m/s som varer en runde.
Det er førstemann til å kjøre 10000m
 
 */