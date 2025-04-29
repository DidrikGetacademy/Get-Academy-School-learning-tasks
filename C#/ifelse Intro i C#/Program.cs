

using System.Collections;

namespace ifelse_Intro_i_C_
{
    public class Program

    {




        public static void Main(string[] args)
        {
            bool IsEqual;
            Console.WriteLine("Skriv inn et tall");
            var userInput = Console.ReadLine();
            int firstnumber = Convert.ToInt32(userInput);


            Console.WriteLine("skriv inn det andre tallet ");
            var secondUserInput = Console.ReadLine();
            int secondnumber = Convert.ToInt32(secondUserInput);


            if (firstnumber == secondnumber)
            {
                IsEqual = true;
              
            }
            else
            {
                IsEqual = false;
                
            }
            Console.WriteLine($"{IsEqual}");

        }

    }

}

//Oppgave 1: Lag en metode som tar imot to tall og returnerer true dersom tallene er like. 