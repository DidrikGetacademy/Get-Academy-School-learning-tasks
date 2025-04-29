using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaveTekstTukling
{
     class TekstTukling
    {

        public TekstTukling()
        {
            Console.WriteLine("1. Rotate Text");
            Console.WriteLine("2. change word");
            Console.WriteLine(" Choose number 1 or 2");
            var MenuChoice = Console.ReadLine();

           switch (MenuChoice)
           {
                case "1":
                    Console.WriteLine("type in the text you want to reverse");
                    var userinput = Console.ReadLine();
                    var reversedtext = new string(userinput.Reverse().ToArray());
                    Console.WriteLine($"{reversedtext}");
                    break;

                case "2":
                    Console.WriteLine("skriv tekst du vil bytte ut alle e med a ");
                    var userinput2 = Console.ReadLine();
                    var modifedText = userinput2.Replace("e", "a");
                    Console.WriteLine($"{modifedText}");

                    break;

                default : Console.WriteLine();
                    break;
           }

        



        }

    }
}
/*
 Oppgave: TekstTukling


   Lag et enkelt kommandobasert program med følgende meny:

   1. RotateText

   2. Change word

   Etter brukeren har valgt 1 eller to skal de promptes for å skrive inn et ord. Ordet skal ta enten snus eller endres med følgende funksjoner

   1 -> En funksjon som tar en tekst som parameter og som returnerer teksten snudd i motsatt rekkefølge. For eksempel skal 'Terje' bli til 'ejreT.

   2 -> En funksjon som bytter ut alle 'e' med 'a' i tekst du sender inn
*/