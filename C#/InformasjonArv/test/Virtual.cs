using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Virtual
    {
        class BaseClass
        {
            public virtual void Display() // virtual metode som kan overskrives i en annen klasse som arver fra denne klassen
            {
                Console.WriteLine("Dette er baseklassens metode.");
            }
        }

        class DerivedClass : BaseClass
        {
            public override void Display() // overskriver metoden fra base klassen
            {
                Console.WriteLine("Dette er avledet klassens metode.");
            }
        }

        class Program
        {
            static void Main()
            {
                BaseClass obj = new DerivedClass(); //objekt av den avledede klassen, holder referanse som en baseklasse
                obj.Display(); // metoden override fra derivedClass blir kjørt her






                //virtual-nøkkelordet er nøkkelen her, da det indikerer at en metode kan overskrives i avledede klasser.
                //Uten virtual kan en metode ikke overskrives i en avledet klasse, og den vil alltid bruke implementasjonen fra basisklassen.
            
            }
        }


    }
}
