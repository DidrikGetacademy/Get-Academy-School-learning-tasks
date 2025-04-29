using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    public class Matvare : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public  DateTime DateTime { get; set; }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Matvare:{Navn}, Pris: {Pris}, Utløpsdato: {DateTime}");
        }
    }
}
