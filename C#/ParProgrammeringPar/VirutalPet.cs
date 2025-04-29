using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringPar
{
    class VirtualPet
    {
        public string name;
        public int age;
        public bool hungry;
        public bool nuggle;
        public bool WC;


        public VirtualPet(
            string name,
            int age = 1,
            bool hungry = true,
            bool nuggle = true,
            bool WC = false

        )
        {
            this.name = name;
            this.age = age;
            this.hungry = hungry;
            this.nuggle = nuggle;
            this.WC = WC;

        }

        public void visStatus()
        {
            Console.WriteLine($"{name} - {age} years old, " +
                              $"{(hungry ? "Hungry," : "Full,")} " +
                              $"{(nuggle ? "Want cuddles," : "Cuddled,")}" +
                              $"{(WC ? "needs toilet" : "i dont need toilet;")}"
            );
        }


        public void feed()
        {
            if (hungry)
            {
                Console.WriteLine("Thank you im now full and satisfied");
                hungry = false;
            }
        }



        public void cuddle()
        {
            if (nuggle)
            {
                Console.WriteLine("Thank you for the cuddle!");
                nuggle = false;
            }
        }



        public void toilet()
        {
            if (WC)
            {
                Console.WriteLine("thank you, i really needed that");
            }
            else Console.WriteLine("i don't need to go to the toilet right now");
        }

        public void ShowAllPets(List<VirtualPet> virtualPets)
        {
            Console.WriteLine("All Pets:");

            foreach (var pet in virtualPets)
            {
                Console.WriteLine($"{pet.name} - {pet.age} years old" +
                  $"{(pet.hungry ? "Hungry," : "Full,")} " +
                  $"{(pet.nuggle ? "Want cuddles," : "Cuddled,")}" +
                  $"{(pet.WC ? "needs toilet" : "i dont need toilet;")}");

               

            }
        }
    }
}

