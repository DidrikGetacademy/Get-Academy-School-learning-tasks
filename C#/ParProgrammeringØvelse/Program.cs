using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<VirtualPet> pets = new List<VirtualPet>();

        int choice;
        do
        {
            Console.WriteLine("1. Add a new pet");
            Console.WriteLine("2. Check pet status");
            Console.WriteLine("3. Feed a pet");
            Console.WriteLine("4. Display all pets");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {




                case 1:
                    Console.WriteLine("Enter the name of your pet:");
                    string newPetName = Console.ReadLine();
                    VirtualPet newPet = new VirtualPet(newPetName);
                    pets.Add(newPet);
                    Console.WriteLine($"{newPetName} added to the pets list.");
                    break;





                case 2:
                    Console.WriteLine("Enter the name of the pet to check:");
                    string petToCheck = Console.ReadLine();
                    VirtualPet selectedPet = pets.Find(p => p.name == petToCheck);
                    if (selectedPet != null)
                    {
                        selectedPet.PrintStatus();
                    }
                    else
                    {
                        Console.WriteLine($"Pet with the name '{petToCheck}' not found.");
                    }
                    break;



                case 3:
                    Console.WriteLine("Enter the name of the pet to feed:");
                    string petToFeed = Console.ReadLine();
                    VirtualPet petToFeedObj = pets.Find(p => p.name == petToFeed);
                    if (petToFeedObj != null)
                    {
                        petToFeedObj.Feed();
                    }
                    else
                    {
                        Console.WriteLine($"Pet with the name '{petToFeed}' not found.");
                    }
                    break;




                case 4:
                    Console.WriteLine("All Pets:");
                    foreach (var pet in pets)
                    {
                        pet.PrintStatus();
                    }
                    break;

                case 0:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

           
            Console.WriteLine();
        } while (choice != 0);
    }
}

