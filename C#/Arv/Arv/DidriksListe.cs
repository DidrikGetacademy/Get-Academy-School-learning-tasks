using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class DidriksListe<T> : List<T>
    {
        public void AddTwo(T itemOne, T itemTwo)
        {
            Add(itemOne);
            Add(itemTwo);
        }
    }
}
