using System.Security.Cryptography.X509Certificates;

namespace Bossfight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // random tall mellom 0-30
            Random random = new Random();
            int randomNumber = random.Next(0, 30);


           //instanser av karakterene
          GameCharacter hero = new GameCharacter("Hero",100,20,40);
          GameCharacterbv  Boss = new GameCharacter("Boss",400,randomNumber,10);


            // bools som er satt til true
            bool Turn = true;
            bool game = true;


     
            hero.playerstats();
            Console.WriteLine();
            Boss.playerstats();
            Console.WriteLine("Trykk enter for å starte spill");
           Console.ReadLine();
            Console.Clear();
            while (game)
            {
             
           

                if (Turn)
                {
                    if (hero._Health <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"{Boss._Name} won the game");
                        game = false;
                    }
                    if(game != false)
                    {

                    
                    hero.Fight(hero, Boss, ref Turn);                
                    Turn = false;
                }

            }
                else if (Turn == false)

                {
                    if (Boss._Health <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"{hero._Name} won the game");
                        game = false;
                    }
                    if(game != false)
                    {

                    
                    Boss.Fight(hero, Boss, ref Turn);
                    Turn = true;
                }
            } 
            }
        }
    }
}


/*
 
Oppgave: Bossfight


Dere skal lage en konsoll app som viser en battle mellom en hero og en boss.

Skriv en klasse GameCharacter som har en metode Fight(), en metode Recharge() og følgende properties:

Health, Strength, Stamina

Program.cs filen må initialisere to objekter av denne klassen, en Hero og en Boss med følgende stats:

Hero:                      Boss:
Health: 100                Health: 400
Strength: 20               Strength: 0-30
Stamina: 40                Stamina: 10

 
        
Disse to skal i kamp frem til en seirer (motstanderen sin health = 0) konsollen skal logge hvem som angriper, hvor mye skade som tas og hvor mye liv motstanderen har igjen etter slaget.

I en fight mister GameCharacterene like mye i Health som mostanderen har i Strength.

Hver gang en character bruker metoden Fight() mister de også 10 stamina.

Om Fight() kalles med 0 i stamina må de bruke metoden Recharge() som restorer Stamina til det de hadde da de startet kampen. De rundene gamecharacterene må recharge får de ikke utført noe skade.
Styrken til Bossen varierer med en random verdi mellom 0-30 for hver gang Fight() kalles. Om dette blir for avansert, la bossen også få en fast styrke på 20.

Eksempel på Konsollens logg når programmet har kjørt ferdig:

 Enemy hit hero with 5 damage, hero now has 30 health left.
 Hero hit enemy with 20 damage, enemy has 0 health left.
Hero is the winner!
 Lykke til smile
        */