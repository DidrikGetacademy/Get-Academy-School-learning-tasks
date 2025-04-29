using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOppgave
{
    internal class ifelse
    {


        /*   public void Run()
           {
               Console.WriteLine("hva er 2 + 2");
               var input = Console.ReadLine();

               switch (input)
               {
                   case "4":
                       Console.WriteLine("Riktig");
                       break;
                   default:
                       Console.WriteLine("prøv igjen");
                       Run();
                       break;
               }*/

        /*  public void Runs()
          {

           Console.WriteLine("hva er 2+1");
           string userInput = Console.ReadLine();

           int number = int.Parse(userInput);


           var result = number switch
           {
               1 => "feil tall",
               2 => "feil tall",
               3 => "riktig tall",
               _ => "ukjent inndata",
           };
           Console.WriteLine($"{result}");

          }*/


        /*public void runner()
        {
            int number = 1;

            Console.WriteLine("Skriv inn et tall mellom 1-7 for å finne ut hvilken dag i uken det er");

            var result = number switch
            {
                1 => "Mandag",
                2 => "tirsdag",
                3 => "onsdag",
                4 => "torsdag",
                5 => "fredag",
                6 => "lørdag",
                7 => "søndag",
            };
           Console.WriteLine($"{result}");
        }


         oppgave 1
           Ha en variabel med datatypen int og gi den en value med et tall mellom 1 og 7. 
           Bruk en switch for å finne ut hvilken dag i uken det tallet er, og print ut dagen med Console.WriteLine();
           Eksempel: 
           1 er mandag, 2 er tirsdag, osv. 
         */




        public void runner2()
        {
            Console.WriteLine("skriv inn et tall mellom 1-7");
            var input = int.Parse(Console.ReadLine());

            string result = null;

            switch (input)
            {
                case 1:
                    result = "Mandag";
                    break;
                case 2:
                    result = "tirsdag";
                    break;
                case 3:
                    result = "onsdag";
                    break;
                case 4:
                    result = "torsdag";
                    break;
                case 5:
                    result = "fredag";
                    break;
                case 6:
                    result = "lørdag";
                    break;
                case 7:
                    result = "søndag";
                    break;
                default:
                    runner2();
                    break;
            }

            Console.WriteLine($"{result}");
        }


        /*
         Oppgave 2: 
       Ta utgangspunkt fra oppgave 1, men istedenfor å bruke en int med en fastsatt value,
        bruker du Console.ReadLine() for at man kan skrive inn et tall i konsollen. Hvis man ikke får inn et tall,
        skal switch-en kjøre programmet på nytt. 
         */
    }
}

