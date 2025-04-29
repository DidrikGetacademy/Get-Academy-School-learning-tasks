using System.Security.Cryptography.X509Certificates;

namespace oppgave2IfElse
{
    internal class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Type a number between 1-10");
            var firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("type a second number between 1-10");
            var secondNum = Convert.ToInt32(Console.ReadLine());

            if (firstNum != secondNum)
            {
                Console.WriteLine($"{addNumbersGenerator(firstNum, secondNum)}");
            }
            else if(firstNum == secondNum)
            {
                Console.WriteLine($"{multiplyNumbersGenerator(firstNum,  secondNum)}");
            }

        }

        public static int addNumbersGenerator(int firstNum, int secondNum)
        {
            Console.Write($" {firstNum} + {secondNum} = ");
            return firstNum + secondNum;
        }

        public static int multiplyNumbersGenerator(int firstNum, int secondNum)
        {
            Console.Write($"{firstNum} * {secondNum} = ");
            return firstNum * secondNum;
        }
    }
}

// Oppgave 2: 
// Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike, 
// og returnerer tallene multiplisert med hverandre dersom de er like