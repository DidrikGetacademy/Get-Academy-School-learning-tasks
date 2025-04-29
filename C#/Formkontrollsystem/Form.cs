using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
     abstract class Form
    {
        public string _Name { get; set; }
        public string _Color { get; set; }

        protected Form(string name, string color)
        {
            _Name = name;
            _Color = color;
        }

    

        public abstract double BeregnAreal();
    }
}
