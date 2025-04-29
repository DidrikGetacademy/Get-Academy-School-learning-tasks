using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    public class Klær : IProdukt
    {
        public string Navn { get; set; }
        public double Pris { get; set; }

        public string Størrelse { get; set; }
        public int PropertyName { get; internal set; }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Klær: {Navn}, Pris: {Pris}, Størrelse: {Størrelse}");
        }
    }
}
