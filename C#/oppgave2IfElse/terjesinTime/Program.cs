using System;

namespace Emne3Demo2
{
    class Program
    {
        // function main(arguments)
        static void Main(string[] arguments)
        {
            var name = MyConsole.Ask("Hva heter du? ");
            Console.WriteLine($"Hei, {name}!");

            var birthYear = MyConsole.AskForInt("I hvilket år er du født? ");
            var age = 2023 - birthYear;

            var hadBirthday = MyConsole.AskForBool("Har du hatt bursdag i år? (j/n)");
            if (!hadBirthday)
            {
                age--;
            }

            Console.WriteLine($"Da er du {age} år gammel.");
        }

        static bool Something()
        {
            int i = 5;
            if (i < 10)
            {
                return true;
            }
            return false;
        }

        //for (var i = 0; i < arguments.Length; i++)
        //{
        //    var value = arguments[i];
        //    Console.WriteLine($"arguments[{i}] = \"{value}\"");
        //}

        //var i = 5;
        //var s = "Terje";


        /*
         * string
         * char
         * int
         * bool
         */
    }
}