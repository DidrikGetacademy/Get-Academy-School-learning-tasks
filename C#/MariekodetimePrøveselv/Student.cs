using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariekodetimePrøveselv
{
     class Student
    {
        private string _navn;
        private int _age;
        private static List<Student> NyStudent = new List<Student>();

        public Student(string navn, int age)
        {
            _navn = navn;
            _age = age;
            NyStudent.Add(this);
          
        }


    

        public void studentIntroduction()
        {
         
            Console.WriteLine($" Navn: {_navn}" +$" Alder: {_age}");
        }


        public static void showallStudents()
        {
        foreach (var student in NyStudent)
            {
                student.studentIntroduction();
            }
        }

    
    
    }
}
