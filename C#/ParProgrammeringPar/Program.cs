using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace ParProgrammeringPar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VirtualPet> petNames = new List<VirtualPet>();
            Console.WriteLine("what will you call your pet?");
            string petName = Console.ReadLine();

            var pet = new VirtualPet(petName);
            petNames.Add(pet);

            int choice;
            do
            {
                
                
                    Console.WriteLine($"1.feed {pet.name}");
                    Console.WriteLine($"2.cuddle {pet.name}");
                    Console.WriteLine($"3.check if {pet.name} needs to go to the toilet");
                    Console.WriteLine("4.add a new pet");
                    Console.WriteLine("5.show all pets");
                    Console.WriteLine("Velg en handling(1-5)");
                    choice = Convert.ToInt32(Console.ReadLine());


                    VirtualPet? newPet;
                    switch (choice)
                {
                    case 1:
                        pet.feed();
                        break;
                    case 2:
                        pet.cuddle();
                        
                        break;
                    case 3:
                        pet.toilet();
                        break;
                    case 4:
                        Console.WriteLine("What will you call your new pet?");
                        string newPetNames = Console.ReadLine();
                        newPet = new VirtualPet(newPetNames);
                        petNames.Add(newPet);
                        Console.WriteLine($"{newPetNames} has been added!");
                        


                        Console.WriteLine($"1.feed {newPet.name}");
                        Console.WriteLine($"2.cuddle {newPet.name}");
                        Console.WriteLine($"3.check if {newPet.name} needs to go to the toilet");
                        Console.WriteLine("4.add a new pet");
                        Console.WriteLine("5.show all pets");
                        Console.WriteLine("Velg en handling(1-5)");
                        choice = Convert.ToInt32(Console.ReadLine());

                            
                        newPet.visStatus();

                        break;
                    case 5:
                        pet.ShowAllPets(petNames);
                        Console.WriteLine("choose pet you want too show status");

                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again!");
                        break;
                }


                
                pet.visStatus();
                Console.WriteLine();
            } while (choice != 0);

        }
    }
}







/* Console.WriteLine("3.check if animal needs to go to the bathroom");
               Console.WriteLine("4.Thank you for giving me food");
               Console.WriteLine("5.Thank you for the cuddles");
               Console.WriteLine("6.Thank you for giving me a toilet break");
              */





/*Lag en konsoll-applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn, age eller noen andre egenskaper utenfra klassen. Lag funksjonalitet som gjør at man kan gi dyret mat, kose med dyret eller sjekke om dyret må på do
Her er et eksempel på hvordan det kan se ut:
Hvilket dyr vil du ta vare på?
Pikachu
1. Gi Pikachu mat
2. Kos med Pikachu
3. Sjekk om Pikachu må på do
2
Pikachu smiler!
1. Gi Pikachu mat
2. Kos med Pikachu
3. Sjekk om Pikachu må på do
1
Pikachu er mett og fornøyd*/



// list<pet> pets = new list <pet>(PetName)for å ha en liste av alle pets
//pets.add(petname)
// var newpet = new virtualpet(petname) ??

// for each (var pet in pets){}