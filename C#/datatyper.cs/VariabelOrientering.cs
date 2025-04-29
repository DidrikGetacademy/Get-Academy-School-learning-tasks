using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convert = System.Convert;

namespace datatyper.cs
{
    public  class VariabelOrientering
    {

        int tall = 1;

        float desimalTall = 1.01F; // nøyaktig
        double desimalTall2 = 1.01;
        decimal desimalTall3 = 1.01M; // veldig nøyaktig

        char bokstav = 'a';
        string tekst = "Hei";

        bool santUsant = true; //eller false

        int[] tallArray = { 1, 2, 3 };
        string[] tekstArray = { "Hei", "på", "deg" };

        private List<int> listeMedTall = new List<int>(); // lager en ny liste med tall.

        public string ReturnString()
        {
            return tekst;
        }


         int tall1 = 1;
         int tall2 = 2;
        public int returnWholeNumber(int number, int number2)
        {
            return number + number2;
        }

        public double ReturnDouble(int number1)
        {
            var number = Console.ReadLine();
            return number1 + Convert.ToDouble(number);
        }

        public bool TrueFalse()
        {
            return santUsant;
        }

        public float returnFloat()
        {
            return desimalTall;
        }

        public char returnChar()
        {
            return bokstav;
        }

        public decimal ReturnDecimal()
        {
            return desimalTall3;
        }

        public int[] returnIntArray()
        {
            return tallArray;
        }

        public string[] returnStrings()
        {
            return tekstArray;
        }

        public void ingenReturVerdiMetode()
        {
            Console.WriteLine("denne metoden returnerer ingenting");
        }

        public void Run()
        {
            Console.WriteLine($"Dette er en string: {ReturnString()}");
            Console.WriteLine($"dette er en int: {returnWholeNumber(tall1, tall2)}");
            Console.WriteLine($"dette er en double: {ReturnDouble(tall1)}");
            Console.WriteLine($"dette er en Bool: {TrueFalse()}");
            Console.WriteLine($"dette er en float: {returnFloat()}");
            Console.WriteLine($"dette er en char: {returnChar()}");
            Console.WriteLine($"dette er en decimal: {ReturnDecimal()}");
            Console.WriteLine($"dette er et int Array{returnIntArray()}");
            Console.WriteLine($"dette er en string array: {returnStrings()}");
            ingenReturVerdiMetode();

        }

    }
}













































