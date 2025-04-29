using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    public class Elektronikk : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }
        public int Garanti { get; set; }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Elektronikk:  {Navn}, Pris: {Pris}, Garantid: {Garanti}");
        }
    }
}
