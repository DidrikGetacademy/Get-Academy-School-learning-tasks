using System.Security.Cryptography.X509Certificates;

namespace datatyper.cs
{
    public class Program
    {
         static void Main(string[] args)
        {




            // chatlog mellom program og user
            // Console.WriteLine("Hva heter du?");
            //var input = Console.ReadLine();
            //Console.Write($"Velkommen {input}");


          


            var variabler = new Variabler();  //opprett en instans av variabler-klassen referert til variabler.cs
            variabler.Run();


            variabler.RunOppgave2();

            var VariabelOrientering = new VariabelOrientering();
            VariabelOrientering.Run();
        }
    }
}







//The command Console.WriteLine() prints text to the console
//The command Console.ReadLine() captures user input in the console





// Tips
//--------------------------------------------------------
//public void DenneFunksjonenReturnererIngenting()
// {
// return;
// }



// Hvis det er en spesifikk datatype den skal returnere, så må det defineres slik: 
// public int DenneFunksjonenReturnererEtHeltall()
// {
// int etTall = 5;
// return etTall;
// }


// public int DenneFunksjonenTarInnToTall(int input1, int input2)
// {	 
// return input1 + input2; //her returneres summen av de to tallene sendt inn i metoden
// }










