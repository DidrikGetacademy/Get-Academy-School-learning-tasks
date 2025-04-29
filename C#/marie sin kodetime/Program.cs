    namespace marie_sin_kodetime
{
    internal class Program
    {
        static void Main(string[] args)
        {

         

            List<Student> Students = new List<Student>()
            {
                new Student("Didrik", 23),
                new Student("Camilla", 30)
        };

            var espen = new Student("Espen", 20);
            Students.Add(espen);

            List<Teacher> teachers = new List<Teacher>() { new Teacher("Marius"), {new Teacher("Marie")} };
            bool runProgram = true;
            while (runProgram)
            {
                RemoveTeacher("Marius");
                Menu();
            }

            void Menu()
            {
                ShowAllStudents();
                Console.WriteLine("Welcome to Get Academy");
                Console.WriteLine("1. show all students");
                Console.WriteLine("2. show all Teachers");
                Console.WriteLine("3. select teacher to perform lecture");
                Console.WriteLine("4.  add new Teacher");
                Console.WriteLine("5. exit program");

                var MenuChoise = Console.ReadLine();

                switch (MenuChoise)
                {
                    case "1":
                        
                        break;


                    case "2":
                        ShowAllTeachers();
                        break;


                    case "3":
                        var teachInput = Console.ReadLine();
                        var teacher = FindTeacher(teachInput);
                        teacher.GiveLecture();
                        break;

                    case "4":
                        addNewTeacher();
                        break;

                    case "5":
                        runProgram = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
           



            void addNewTeacher()
          {
          Console.WriteLine("what is the name of the new teacher?");
          var Nameinput = Console.ReadLine();
                teachers.Add(new Teacher(Nameinput));
          }


            void RemoveTeacher(string nametoremove)
            {
                Console.WriteLine("what is the name of teacher you want to remove?");
                var teacherRemove = FindTeacher(nametoremove);
                teachers.Remove(teacherRemove);


            }


            void ShowAllTeachers()
          {
              foreach (var teacher in teachers)
              {
                  teacher.introduction();
              }
          }



          void ShowAllStudents()
          {
              foreach (var student in Students)
              { 
                student.introduction();
              }
          }


            void studentWatchLecture()
            {
                foreach (var student in Students)
                {
                    student.lecture();
                }
            }



            Teacher FindTeacher(string name)
            {
               var teacher = teachers.Where(teacher => teacher.name == name).FirstOrDefault();
               return teacher;
            }
        }
    }
}
