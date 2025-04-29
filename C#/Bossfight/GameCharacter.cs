using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Bossfight
{
    internal class GameCharacter
    {

        public string _Name { get; set; }

        public int _Health { get; set; }

        private int _Strength { get; set; }

       public int _Stamina { get; set; }


        public GameCharacter( string name, int health, int strength, int stamina) 
        {
            _Name = name;

            _Health = health;

            _Strength = strength;

            _Stamina = stamina;

        }


        public void Winner(GameCharacter hero, GameCharacter Boss, ref bool Turn)
        {
            if (hero._Health <= 0)
            {
                Turn = true;
            }
            if (Boss._Health <= 0)
            {
                Turn = false;
            }
        }

        public void Fight(GameCharacter hero, GameCharacter Boss, ref bool Turn)
        {
            Winner(hero,Boss, ref Turn);
            Console.WriteLine($"Press a button to hit {Boss._Name}");
            var input = Console.ReadLine();
   
            if (input != null)
            {
           
                if (hero._Stamina <= 0)
                {
                    Console.WriteLine($"{hero._Name} is out of stamina! Recharging...");
                    hero.Recharge(hero, Boss, ref Turn);
                    return;  
                }

                Boss._Health -= hero._Strength;
                hero._Stamina -= 10;

                Console.WriteLine();
                Console.WriteLine("Stats:");
                Console.WriteLine($"{hero._Name} hit {Boss._Name} with {hero._Strength} damage");
                Console.WriteLine($"{Boss._Name} now has {Boss._Health} health left.");
          
                Console.WriteLine("..................");
                Boss.playerstats();
                Console.WriteLine();
                hero.playerstats();
            
            } 







            Console.WriteLine($"Press a button to hit {hero._Name}");
            var input1 = Console.ReadLine();
            if (input1 != null)
            {
         

                if (Boss._Stamina <= 0)
                {
                    Console.WriteLine($"{Boss._Name} is out of stamina! Recharging...");
                    Boss.Recharge(hero, Boss, ref Turn);
                    return;
                }


           
                Console.WriteLine();
                hero._Health -= Boss._Strength;
                Boss._Stamina -= 10;
                Console.WriteLine() ;   
                Console.WriteLine("Stats:");
                Console.WriteLine($"{Boss._Name} hit {hero._Name} with {Boss._Strength} damage");
                Console.WriteLine($"{hero._Name} now has {hero._Health} health left");
                Console.WriteLine("..................");
                hero.playerstats();
                Console.WriteLine();
                Boss.playerstats(); 
            }
        }










        public void Recharge(GameCharacter hero, GameCharacter Boss, ref bool Turn)
        {
            if (Turn == true && hero._Stamina <= 0)
            {
                Turn = false;
                hero._Stamina = 40;
                Console.WriteLine($" {hero._Name} har nå fått {hero._Stamina}  stamina ");

              
            }else if (Turn == false && Boss._Stamina <= 0)
            {
                Boss._Stamina = 10;
                Console.WriteLine($" {Boss._Name} har nå fått {Boss._Stamina} stamina ");
              
            }
        }





        public void playerstats()
        {
            Console.WriteLine();
            Console.WriteLine("Karakter:");
            Console.WriteLine($"Type: {_Name} ");
            Console.WriteLine($"Health: {_Health}");
            Console.WriteLine($"Strength: {_Strength}");
            Console.WriteLine($"Stamina: {_Stamina}");
        }


    }
}
