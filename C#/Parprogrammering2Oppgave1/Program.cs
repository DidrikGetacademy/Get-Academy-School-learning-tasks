using System;
using System.Collections.Generic;

namespace Parprogrammering2Oppgave1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<elev> elever = new List<elev>()
            {
                new elev("Didrik", 23),
                new elev("Lisbeth", 23)
            };

            Console.WriteLine("Velkommen");

            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("Velg elev du vil se egenskap og hobbyen til");
                Console.WriteLine("1. Didrik");
                Console.WriteLine("2. Lisbeth");
                Console.WriteLine("3. Avslutt");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        elever[0].ShowInfo();
                        Console.WriteLine("Trykk 1 for å utføre hobby");
                        if (Console.ReadLine() == "1")
                        {
                            elever[0].PerformHobbyDidrik();
                        }

                        break;
                    case "2":
                        elever[1].ShowInfo();
                        Console.WriteLine("Trykk 1 for å utføre hobby");
                        if (Console.ReadLine() == "1")
                        {
                            elever[1].PerformHobbyLisbeth();
                        }

                        break;
                    case "3":
                        runProgram = false;
                        break;
                    default:
                        Console.WriteLine("Ugyldig valg");
                        break;
                }
            }
        }
    }
}
/*
I denne oppgaven skal du prøve å programmere deg selv 🤓 Du har noen gitte egenskaper og ting du liker å gjøre.
Lag et hovedprogram der hver av deltakerene har sin klasse som kan printe ut en introduksjonstekst,
og også utføre hver sine hobbyer.

   Utskrift i konsollen kan feks se sånn her ut:
   Hei, jeg heter Bjarne! Jeg er 40 år gammel og jeg har svart hår
   Se på meg, nå løper jeg i åkeren.
   Nå sitter jeg og gamer litt farmingsimulator!

   Hei, jeg heter Kurt! Jeg er 55 år gammel og jeg har brunt hår
   Nå er jeg ute på fisketur.
   Se, jeg kan også klatre høyt i klatreparken!
 */