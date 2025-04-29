using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Character
    {
        
        public string Name { get; set; }

        public string House { get; set; }

        public List<Pet> pets { get; set; }

        public List<Wand> wands { get; set; }

        public Character(string name, string house)
        {
            Name = name;
            House = house;
            pets = new List<Pet>();
            wands = new List<Wand>();

        }
        public void Introduction()
        {
            Console.WriteLine($"Hey my name is {Name}, i belong to {House}");
            PrintPets();
        }

        private void PrintPets()
        {
            foreach (var pet in pets)
            {
                Console.WriteLine(" i have a " + pet.PetType);
            }
        }

        public void enterMagicShop()
        {
           
        }

        public void BuyItem()
        {

        }

        public void performMagic()
        {

        }
    }
}
