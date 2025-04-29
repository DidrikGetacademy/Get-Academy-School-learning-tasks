using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Abstract
    {

        //I C# brukes abstract-nøkkelordet for å definere en abstrakt klasse eller metode. 
        //En abstrakt klasse er en klasse som ikke kan instantieres direkte, men kan ha abstrakte metoder som må implementeres av alle avledede klasser.
        //Abstrakte metoder, på den annen side, er metoder som er deklarert i en abstrakt klasse, men de gir ingen implementasjon i selve klassen. 
        //Implementasjonen må gis i avledede klasser.
        public abstract class Shape
        {
            // Abstrakt metode uten implementasjon
            public abstract void Draw();

            // Vanlig (ikke-abstrakt) metode med implementasjon
            public void Display()
            {
                Console.WriteLine("Dette er en generell metode i abstrakt klassen.");
            }
        }

        public class Circle : Shape
        {
            // Implementerer den abstrakte metoden fra Shape
            public override void Draw()
            {
                Console.WriteLine("Tegner en sirkel");
            }
        }

        class Program
        {
            static void Main()
            {
                // Kan ikke opprette en instans av en abstrakt klasse
                // Shape shape = new Shape(); // Dette vil gi en feil

                // Men kan opprette en instans av en avledet klasse
                Shape circle = new Circle();
                circle.Draw(); // Kalles den implementerte Draw-metoden i Circle-klassen
                circle.Display(); // Kalles den generelle Display-metoden fra abstrakt klassen







             //I dette eksempelet er Shape en abstrakt klasse med en abstrakt metode Draw().
             // Den har også en vanlig metode Display() med implementasjon. Circle er en avledet klasse som arver fra Shape og implementerer den abstrakte metoden Draw()
             //Husk at abstrakte klasser er nyttige når du har en felles struktur og funksjonalitet som skal deles av flere klasser, men du ønsker ikke å tillate direkte instansiering av den abstrakte klassen.
            }
        }

    }
}
