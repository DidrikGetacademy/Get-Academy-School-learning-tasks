using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Codealong
{
  public  class Handlekurv
    {
        private List<Produkter> _produkteriHandlekurv = new List<Produkter>(); // en ny liste av produkter i handlekurven som har blitt tildelt variabel navn (_produkterihandlekurv)


        //metode som legger til et produkt ihenhold til parameter
        public void AddToCart(Produkter produkt)
        {
            _produkteriHandlekurv.Add(produkt);
            Console.WriteLine($"{produkt.GetProductName()} lagt til i handlekurven");
        }


        //metode som viser frem alle produkter i listen (_produkterihandlekurv)
        public void vishandlekurv()
        {
            foreach (var products in _produkteriHandlekurv) // foreach blar igjennom alle produtker i listen
            {
                products.produktInfo();
            }
        }

    }
}
