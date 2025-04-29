using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloads_og_Default_values
{
    public class methodsAgain
    {
        public string message;

        public int age;

        public string name;

        public methodsAgain(string Message)
        {
            message = Message;
        }


        public methodsAgain(string Message, int Age)
        {
            message = Message;
            age = Age;

        }


        public methodsAgain(string Message, string Name, int Age)
        {
            message = Message;
            age = Age;
            name = Name;
        }

        public void Print(string ekstrainfo  = " Didrik")
        {
            Console.WriteLine(message +  ekstrainfo );
        }

    }

}
