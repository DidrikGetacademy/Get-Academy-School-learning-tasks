using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong
{
  public  class Store
    {
        private Produkter _produkter; //
        private Handlekurv _handlekurv; //


        // konstruktor som samarbeider med produkter og handlekruv klassene/cs 
        // henter ut objekter av produtker og handlekurv for å gjøre det mulig og hente ut informasjon 
        public Store(Produkter produkter, Handlekurv handlekurv)
        {
            // constructor som tar imot andre klasser som parameter
            _produkter = produkter;
            _handlekurv = handlekurv;
        }

        // metode som viser frem butikk produkter
        public void ShowStoreProducts()
        {
            Console.WriteLine("Butikkens produkter: ");
            _produkter.visalleprodukter(); // henter ut en metode fra produkter.cs klassen
        }


        // metode for å legge til produkter fra bruker i handlekurv 
        public void addProduktTilHandlekurv()
        {
            Console.WriteLine();
            Console.WriteLine("Skriv inn navn på produkt du vil legge til i handlekurv");// bruker skriver inn navn på vare de vil legge til i handlekurv 
            var userInput = Console.ReadLine(); // det bruker skriver blir lagret i variabel (userinput)


            Produkter selectedproduct = _produkter.getProductByname(userInput); // selectedproduct er en variabel som kjører metoden i produktklassen som heter (getproductsbyname) som tar brukerinput som parameter

            if (selectedproduct != null)
            {
                // vis variabelen eller det bruker skriver inn sammensvarer med et produkt i listen så blir det lagt til i handlekurven 
                _handlekurv.AddToCart(selectedproduct);
            }
            else
            {
                // vis ikke det brukeren skriver inn sammensvarer med et produkt i listen
                Console.WriteLine("Produktet Finnes ikke");
            }
        }
    }
}
