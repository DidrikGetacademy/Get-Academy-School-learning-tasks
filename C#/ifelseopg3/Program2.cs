using System;
using System.ComponentModel.Design;

namespace ifelseopg3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Skriv inn et tall");
            var firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv inn siste tallet");
            var secondNum = Convert.ToInt32(Console.ReadLine());


            bool isEqual = true;
            Console.WriteLine(BoolAnswear(firstNum, secondNum, isEqual));
        }

        public static bool BoolAnswear(int firstNum, int secondNum, bool isEqual)
        {
            if (firstNum + secondNum == 30)
            {
                return isEqual;
            }

            return false;

            ;

        }
    }
}

/* Oppgave 3:
   Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30,
   skal metoden returnere true. Ellers returnerer metoden false*/