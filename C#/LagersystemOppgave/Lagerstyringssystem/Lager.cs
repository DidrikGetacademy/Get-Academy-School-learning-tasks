using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    public class Lager
    {
       private List<IProdukt> produkter = new List<IProdukt>();


      public void AddProduct(IProdukt produkt)
       {
            produkter.Add(produkt);
       }

       public void RemoveProduct(IProdukt produkt)
       {
           produkter.Remove(produkt);
       }

       public void ShowProducts()
       {
           foreach (var products in produkter)
           {
               products.SkrivUtInfo();
           }
       }
    }
}
