using System;
using System.Collections.Generic;

class Car
{
    public string Brand { get; set; }
    public int Year { get; set; }
    public string RegistrationNumber { get; set; }
    public int Kilometer { get; set; }

    public override string ToString()
    {
        return $"{Year} {Brand} ({RegistrationNumber}) - {Kilometer} km";
    }
}

class CarDealer
{
    private List<Car> cars;

    public CarDealer()
    {
        cars = new List<Car>();
        // Legg til noen eksempelbiler
        cars.Add(new Car { Brand = "Toyota", Year = 2020, RegistrationNumber = "ABC123", Kilometer = 15000 });
        cars.Add(new Car { Brand = "Honda", Year = 2019, RegistrationNumber = "XYZ789", Kilometer = 20000 });
        // Legg til flere biler etter behov
    }

    public void DisplayCars()
    {
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }

    public List<Car> GetCarsByYearRange(int startYear, int endYear)
    {
        return cars.FindAll(car => car.Year >= startYear && car.Year <= endYear);
    }

    public List<Car> GetCarsByKilometer(int maxKilometer)
    {
        return cars.FindAll(car => car.Kilometer <= maxKilometer);
    }

    public void BuyCar(Car car)
    {
        if (cars.Contains(car))
        {
            Console.WriteLine($"Congratulations! You've bought the {car.Brand}.");
            cars.Remove(car);
        }
        else
        {
            Console.WriteLine("Sorry, the selected car is not available.");
        }
    }
}

class Program
{
    static void Main()
    {
        CarDealer carDealer = new CarDealer();

        Console.WriteLine("Available Cars:");
        carDealer.DisplayCars();

        // Eksempel: Hent biler fra et bestemt årspenn
        Console.WriteLine("\nCars from 2019 to 2022:");
        List<Car> selectedCars = carDealer.GetCarsByYearRange(2019, 2022);
        foreach (var car in selectedCars)
        {
            Console.WriteLine(car);
        }

        // Eksempel: Hent biler med mindre enn 18000 km
        Console.WriteLine("\nCars with less than 18000 km:");
        selectedCars = carDealer.GetCarsByKilometer(18000);
        foreach (var car in selectedCars)
        {
            Console.WriteLine(car);
        }

        // Eksempel: Kjøp en bil
        Console.WriteLine("\nBuying a car:");
        carDealer.BuyCar(selectedCars[0]);

        Console.WriteLine("\nUpdated Car List:");
        carDealer.DisplayCars();
    }
}

/*Bilforhandleren
En bilforhandler har ulike biler i shappa si, 


det kan være biler med ulike merker, 
årsmodell,
registreringsnummer og kilometerstand. 


    Når kunden kommer inn i shappa skal han kunne se hvilke biler som finnes i shappa, eller han kan velge å finne en bil ut fra årsrange,
    eller en bil som har kjørt mer eller mindre enn en gitt kilometerstand.
    Kunden skal også ha mulighet til å kjøpe en av bilene. Bilen må da tilhøre kunden og ikke forhandleren.*/