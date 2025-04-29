using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ØvingCodeAlong
{
    internal class Person
    {
       public string _Navn { get; private set; }


       public Person(string Navn)
       {
           _Navn = Navn;

       }


       public void Introduction()
       {
  Console.WriteLine($"Navn: {_Navn}");
       }
    }
}
