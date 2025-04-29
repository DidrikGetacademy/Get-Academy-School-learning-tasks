using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariekodetimePrøveselv
{
    internal class Teacher
    {
        private string _Navn;
        private int  _Alder;
        private static List<Teacher> Teachers = new List<Teacher>();

        public Teacher(string navn, int age)
        {
            _Navn = navn;
            _Alder = age;
            Teachers.Add(this);
        }


        public void TeacherIntroduction()
        {
            Console.WriteLine($"Navn: {_Navn} Alder: {_Alder}");
        }


        public static void ShowallTeachers()
        {
            foreach (var AllTeachers in Teachers)
                AllTeachers.TeacherIntroduction();
        }

        public static void AddTeacher(string Navninput, int AlderInput)
        {
            new Teacher(Navninput, AlderInput);
            Console.WriteLine(" Ny lærer lagt til ");
        }
    }
}
