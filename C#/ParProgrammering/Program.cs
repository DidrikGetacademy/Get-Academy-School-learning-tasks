using System;

class VirtualPet
{
    private string name;
    private int age;
    private bool hungry;
    private bool happy;
    private bool bathroom;

    public VirtualPet(
        string name,
        int age = 1, 
        bool hungry = false,
        bool happy = false,
        bool bathroom = false
        )
    {
        this.name = name;
        this.age = age;
        this.hungry = hungry;
        this.happy = happy;
        this.bathroom = bathroom;
    }

    public void PrintStatus()
    {
        Console.WriteLine($"{name} (Age: {age}) - " +
                          $"{(hungry ? "Hungry" : "Full")}, " +
                          $"{(happy ? "Happy" : "Sad")}, " +
                          $"{(bathroom ? "Needs to go to the bathroom" : "Does not need to go to the bathroom")}");
    }

    public void Feed()
    {
        Console.WriteLine($"{name} is now full and satisfied.");
        hungry = false;
    }

    public void Play()
    {
        Console.WriteLine($"{name} is happy and smiling!");
        happy = true;
    }

    public void CheckBathroom()
    {
        if (bathroom)
            Console.WriteLine($"{name} needs to go to the bathroom!");
        else
            Console.WriteLine($"{name} does not need to go to the bathroom right now.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Which pet would you like to take care of?");
        string petName = Console.ReadLine();

        VirtualPet pet = new VirtualPet(petName);

        int choice;
        do
        {
            Console.WriteLine("1. Feed the pet");
            Console.WriteLine("2. Play with the pet");
            Console.WriteLine("3. Check if the pet needs to go to the bathroom");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    pet.Feed();
                    break;
                case 2:
                    pet.Play();
                    break;
                case 3:
                    pet.CheckBathroom();
                    break;
                case 0:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            pet.PrintStatus();
            Console.WriteLine();
        } while (choice != 0);
    }
}
