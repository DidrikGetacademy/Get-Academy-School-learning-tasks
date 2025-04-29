using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace codealong
{
    public class user
    {
        public List<Pokemon> UserPokemons { get; set; }
        public string name { get; set; }

        public Pokemon pokemon { get; set; }


        Random Random { get; set; }
        public user(string Name)
        {
            name = Name;
            UserPokemons = new List<Pokemon>();
            pokemon = new Pokemon();
            Random = new Random();
        }


        void ChooseStartPokemon()
        {
            pokemon.printPokemons();
            Console.WriteLine();
            Console.WriteLine("Choose Start-Pokemon");
            Console.WriteLine("Name: ");
            Console.WriteLine("2. Enter Menu: ");
            var ChoosenPokemon = Console.ReadLine();
            var pokemonsinlist = pokemon.Pokemons.FirstOrDefault(x => x.Name == ChoosenPokemon);
            if (pokemonsinlist != null)
            {
                UserPokemons.Add(pokemonsinlist);
                pokemon.Pokemons.Remove(pokemonsinlist);
                Console.WriteLine($"du har lagt til " + pokemonsinlist.Name);
            }
            else
            {
                Console.WriteLine("Try again");
                ChooseStartPokemon();
            }
            if(ChoosenPokemon == "2")
            {
             
            }
         
        }







        void Battle()
        {
            if (UserPokemons.Count < 1)
            {
                Console.WriteLine("choose start pokemon first");
            } else
            {
                while (!dead())
                {
                    updateBattleInfo();

                }
            }

        }

        void updateBattleInfo()
        {

            var random = Random.Next(pokemon.Pokemons.Count);
            var UserPokemonFigther = UserPokemons.FirstOrDefault();
            var enemyPokemon = pokemon.Pokemons[random];
            Console.WriteLine("Name: " + UserPokemonFigther.Name + " Health: " + UserPokemonFigther.Health);
            Console.WriteLine("Name: " + enemyPokemon.Name + " Health: " + enemyPokemon.Health);
            Console.WriteLine();
            Console.WriteLine("1.Fight");
            string userinput = Console.ReadLine();
            Fight(userinput, UserPokemonFigther, enemyPokemon);
            enemyAttack(UserPokemonFigther, enemyPokemon);
            Winner(UserPokemonFigther, enemyPokemon);
        }

        void Fight(string userinput, Pokemon userpokemon, Pokemon enemypokemon)
        {
            var userrandomDamage = Random.Next(0, 12);
            userpokemon.Damage = userrandomDamage;
            if (userinput == "1")
            {
                enemypokemon.Health -= userpokemon.Damage;
                Console.WriteLine($"{userpokemon.Name} hit {enemypokemon.Name} with  {userpokemon.Damage} Damage");
            } else
            {
                Console.WriteLine("Wrong Input");
            }
        }

        void enemyAttack(Pokemon userPokemon, Pokemon enemypokemon)
        {
            userPokemon.Health -= enemypokemon.Damage;
            Console.WriteLine($"{enemypokemon.Name} hit {userPokemon.Name} with {enemypokemon.Damage} Damage");
        }


        void Winner(Pokemon userpokemon, Pokemon enemypokemon)
        {
            if (userpokemon.Health < 0)
            {
                Console.WriteLine($"{enemypokemon.Name} wins!");
            } else
            {
                Console.WriteLine($"{enemypokemon.Name} wins!");
            }
        }

        bool dead()
        {
            var Userpokemon = UserPokemons.FirstOrDefault();
            var enemypokemon = pokemon.Pokemons.FirstOrDefault();
            return Userpokemon.Health <= 0 || enemypokemon.Health <= 0;
        }


        void CatchPokemon()
        {

            bool trying = true;
            var randomIndex = new Random();
            int random2 = randomIndex.Next(0, 3);
            var RandomIndex = Random.Next(0, pokemon.Pokemons.Count);
            int Counts = 3;


            while (trying)
            {
              
                Pokemon RandomPokemon = pokemon.Pokemons[RandomIndex];
                Console.WriteLine("WildPokemon: " + RandomPokemon.Name);
                Console.WriteLine($"1.Catch Pokemon");
                var input = Console.ReadLine();


                if (input != null && random2 > RandomIndex)
                {
                UserPokemons.Add(RandomPokemon);
                Console.WriteLine("You caught " + RandomPokemon.Name + " added too list ");
                    Console.ReadLine();
                    Menu();
                 }
                  if(random2 < RandomIndex)
                {
                    Counts--;
                    Console.WriteLine($"Failed trying to catch {RandomPokemon.Name}, {Counts} left");
                    if (Counts == 0)
                    {
                        Menu();
                    }
                }
              

        }




    }



     




        public  void Menu()
        {

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to the pokemon app!");
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. choose start-pokemon");
                Console.WriteLine("2.Battle");
                Console.WriteLine("3.Catch wild pokemon");
                Console.WriteLine("4. exit");
                int userinput = Convert.ToInt32(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        ChooseStartPokemon();
                        break;

                    case 2:
                        Battle();
                        break;

                       

                    case 3:

                        CatchPokemon();
                        break;

                    case 4:

                        Environment.Exit(0);
                        break;
                }
            }

        }

        /*

     

        Du skal lage et utvalg av forskjellige pokemon med ulik styrke og helse som lever i pokemonworld.
        Brukeren skal kunne velge en av disse han ønsker å spille med.
        Mostanderen velges så tilfelding blant utvalget som er igjen. Disse to skal kjempe mot hverandre til en av dem har 0 i helse.
        Consollen logger ut hvor mye helse de har igjen for hvert slag. Brukeren skal også kunne velge å “fange en ny pokemon” som blir med i utvalget hans.

         */
    }
}
