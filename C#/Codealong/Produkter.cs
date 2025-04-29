using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong
{
    public class Produkter
    {
        private string _name { get; set; }
        private int _pris { get; set; }

        List<Produkter> produktliste = new List<Produkter>();// en liste til alle produktene lagret i variabelen produktliste



        public Produkter()
        {
            // tom constructor 
        }
        public Produkter(string Navn, int Pris)
        {
            // constructor med navn og pris på produkter
        _name = Navn;
        _pris = Pris;
        }


        // metode som viser produkt informasjon
        public void produktInfo()
        {
            
            Console.WriteLine($"Produkt: {_name}, Pris: {_pris}");
        }


        // metode som viser alle produkter fra (produktliste)
        public void visalleprodukter()
        {
            foreach (var produkt in produktliste)
            {
                produkt.produktInfo();
            }
        }


        // Metode som legger til produkter i listen (produktliste)
        public void leggtilprodukter()
        {
            produktliste.Add(new Produkter("Egg", 20)); // ny produkt
            produktliste.Add(new Produkter("Mel", 25));// ny produkt
            produktliste.Add(new Produkter("Melk", 15));// ny produkt
        }

        public string GetProductName()
        {
            return _name; // returnerer produkt navn
        }


        // metode som søker igjennom produktlisten basert på input fra bruker
        // parameteren er (userinput)
        public Produkter getProductByname(string productName)
        {
            return produktliste.FirstOrDefault(p => p.GetProductName().Equals(productName, StringComparison.OrdinalIgnoreCase));
        }
    }
}

