using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIntro
{
    class Bil : Itransportation
    {
        public string Brand { get; set; }
        public string RegistrationNumber { get; set; }
        public void Drive()
        {
           // trykk på pedalen
        }
    }
}
