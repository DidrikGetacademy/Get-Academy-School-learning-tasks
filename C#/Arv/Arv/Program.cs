namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<int> vanligList = new List<int>();
         DidriksListe<int> minliste = new DidriksListe<int>();

         vanligList.Add(1);
         minliste.AddTwo(1,2);
         vanligList.ForEach(x => Console.WriteLine(x));
         minliste.ForEach(x => Console.WriteLine(x));
        }
    }
}
