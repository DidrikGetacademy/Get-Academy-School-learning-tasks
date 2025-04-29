using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marie_sin_kodetime
{
    internal class Teacher
    {
        public string name;

        public Teacher(string Name)
        {
            name = Name;
        }



        public void introduction()
        {
            Console.WriteLine($"Teacher: {name} ");
        }

        public void GiveLecture()
        {
            Console.WriteLine($"{name} is holding a lecture");
        }
    }
}
