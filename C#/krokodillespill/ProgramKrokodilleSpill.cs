using System;

namespace krokodillespill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuePlaying = true;
            Random rand = new Random();
            int points = 0;

            while (continuePlaying)
            {
                var randomNumber = rand.Next(0, 11);
                var randomNumber2 = rand.Next(0, 11);
                var option1 = ">";
                var option2 = "<";
                var option3 = "=";
              

                Console.Write($"{randomNumber} _ {randomNumber2}");
                var userinput = Console.ReadLine();

                if (randomNumber > randomNumber2)
                {
                    if (userinput == option1)
                    {
                        points++;
                        Console.WriteLine($"du svarte riktig {randomNumber}  {userinput} {randomNumber2} poeng: {points}");
                    }
                    else
                    {
                        points--;
                        Console.WriteLine($"feil svar, prøv på nytt du har nå poeng: {points}");
                    }
                }
                else if (randomNumber < randomNumber2)
                {
                    if (userinput == option2)
                    {
                        points++;
                        Console.WriteLine($"du svarte riktig {randomNumber} {userinput} {randomNumber2} poeng: {points}");
                    }
                    else
                    {
                        points--;
                        Console.WriteLine($"feil svar, prøv på nytt du har nå poeng: {points}");
                    }
                }
                else
                {
                    if (userinput == option3)
                    {
                        points++;
                        Console.WriteLine($"du svarte riktig {randomNumber} {userinput} {randomNumber2} poeng: {points}");
                    }
                    else
                    {
                        points--;
                        Console.WriteLine($"feil svar, prøv på nytt du har nå poeng: {points}");
                    }
                }

              
            }
        }
    }
}

/*
 Du skal bruke det du har lært til å programmere “krokodille spillet”.

   For hver runde skal det printes ut til skjermen et random tall mellom 1-11, et mellomrom og et nytt tall mellom 1-11 med en underscore mellom slik at det ser sånn ut: 3 _ 5

   Brukeren kan skrive inn <, > eller =

   i tilfellet brukeren får 3 _ 5 vil svaret være <, altså 3 < 5

   Tallene må sjekkes om det første er større eller mindre eller lik det andre tallet,
   Det må verifiseres om brukeren har valgt riktig alternativ.
   Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
   Poengsummen printes til skjermen for hvert svar brukeren har gitt.
   Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene
 */