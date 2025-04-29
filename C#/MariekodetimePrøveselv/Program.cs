namespace MariekodetimePrøveselv
{
    internal class Program
    {
        static void Main(string[] args)
        {





            Student student1 = new Student("Didrik", 23);
            Student student2 = new Student("Arne", 22);

            Teacher teacher1 = new Teacher("Linda", 29);
            Teacher teacher2 = new Teacher("Martin", 25);
            bool program = true;
            while (program)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Get Academy");
                Console.WriteLine("1. show all students");
                Console.WriteLine("2. show all Teachers");
                Console.WriteLine("3. select teacher to perform lecture");
                Console.WriteLine("4. add new Teacher");
                Console.WriteLine("5. exit program");
                var input = Console.ReadLine();

                switch (input)
    
                {

                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Studenter: ");
                        Student.showallStudents();
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Teachers: ");
                        Teacher.ShowallTeachers();
                        break;


                    case "3":

                        break;

                    case "4":
                        Console.WriteLine();
                        Console.WriteLine(" Skriv inn navn: ");
                        var NavnInput = Console.ReadLine();
                        Console.WriteLine(" Skriv inn alder");
                        var alderinput = int.Parse(Console.ReadLine());
                        Teacher.AddTeacher(NavnInput, alderinput);

                        break;


                    case "5":
                        program = false;
                        break;

                    
           }
            }
        }
    }
}
