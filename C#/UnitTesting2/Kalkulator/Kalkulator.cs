using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Kalkulator
    {
        public int LeggSammen(int a, int b)
        {
            return a + b;
        }

        public int TrekkFra(int a, int b)
        {
            return a - b;
        }

        public int Multipliser(int a, int b)
        {
            return a * b;
        }

        public int Divider(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
/*
 Oppgavetrinn:
   Sett opp Unittest-prosjekt: 
   Skriv Unittests:
   Skriv unittests for hver av metodene i Kalkulator-klassen.
   Test ulike scenarier, inkludert positive og negative tall, divisjon med null, etc.
 */