using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marie_sin_kodetime
{
    public  class Student
    {
         public string name;
         public int age;
         public bool isintern;


         public Student(string navn, int alder)
         {
             name = navn;
             age = alder;
         }

       

         public void introduction()
         {
             Console.WriteLine($"student: {name}  age: {age} years old");
        }
        public void lecture()
         {
             Console.WriteLine($"{name} is watching a lecture");
         }
    }
}
