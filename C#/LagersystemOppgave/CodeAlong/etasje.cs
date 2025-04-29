using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong
{
    public class etasje
    {
        public int Floor { get; set; }

        public List<rom> Romnavn = new List<rom>();

        public etasje(int floor)
        {
            Floor = 1;
            Romnavn = new List<rom>();
   
        }
}

}

