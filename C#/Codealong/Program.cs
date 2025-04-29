using System.Runtime.InteropServices;

namespace Codealong
{
    internal class Program
    {
      public  static void Main(string[] args)
      {

        //Oppretter instanse av produkterKlassen
          Produkter produkter = new Produkter();

          // en metode i produkterKlassen som legger til nye produkter etter navn og pris 
          produkter.leggtilprodukter();

       

        // Oppretter en ny instanse av HandlekurvKlassen
          Handlekurv handle = new Handlekurv();


          //Oppretter en ny instanse av StoreKlassen med 2 parametere som sendes som argumenter til  konstruktøren
          // sånn at store kan samhandle med både produkter klassen og handlekurvk klassen.
          Store store = new Store(produkter,handle);

          // en bool (program) som er satt til true;
            bool program = true;

           // while loop med boolen (program) som er true så whileloopen vil kjøre kodelinjene i loop under så lenge program er true; 
            while (program)
            {

                // kodelinjer for menyen
                Console.WriteLine("Meny");
                Console.WriteLine("1. vis produkter i butikk");
                Console.WriteLine("2. Se handlekurv");
                var input = Console.ReadLine(); // variabl som tarimot og lagrer det bruker skriver
            
                Console.WriteLine(); // legger til et mellomrom 
                switch (input)
                {
                    case "1":
                        store.ShowStoreProducts(); // metode fra store.cs/klassen som viser frem alle produkter i store.
                        store.addProduktTilHandlekurv(); // metode fra store.cs/klassen som legger til produkter i handlekurven
                        break;

                    case "2":
                        handle.vishandlekurv();// metode fra handlekurv klassen som viser alle produkter lagt til i handlekurven
                        break;
                    case "5":
                        program = false;// setter bool (program) til false sånn at programmet avsluttes vi bruker velger (5)
                        break;

                    default:
                        Console.WriteLine("Feil svar, prøv igjen");// en default som forteller bruker at det har blitt tastet ugyldig
                        break;
                }
            }
        }
    }
}
