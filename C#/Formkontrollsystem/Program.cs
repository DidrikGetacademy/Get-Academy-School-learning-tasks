using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Formkontrollsystem
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            List<Form> forms = new List<Form>(); 
          forms.Add(new Circle("Circle","purple",1.16));
          forms.Add(new Circle("Circle", "red", 3));
          forms.Add(new Rectangle("Rectangle","White",10,10));
          forms.Add(new Rectangle("Rectangle", "Purple", 15, 15));
          forms.Add(new Triangle("Triangle","white",20,25));
          forms.Add(new Triangle("Triangle", "red", 5, 20));

          foreach (var form in forms)
          {
              Console.WriteLine($"Navn: {form._Name}, Farge: {form._Color}, Areal: {form.BeregnAreal()}");
          }

         
          sortfromlowtohighAreal(forms);
              


          Console.WriteLine("Formene filtrert etter farge (red):");
          FiltrerColor(forms, "red");
   
          Console.WriteLine("Formene filtrert etter farge (purple):"); 
          FiltrerColor(forms, "purple");
      
          Console.WriteLine("Formene filtrert etter farge (white):");
          FiltrerColor(forms, "white");








            static double TotalAreal(List<Form> former)
          {
              double totalAreal = 0;
              foreach (var form in former)
              {
                  totalAreal += form.BeregnAreal();
              }
              return totalAreal;
          }



          static void sortfromlowtohighAreal(List<Form> former)
          {
              Console.WriteLine();
              Console.WriteLine($"Totalt Areal: {TotalAreal(former)}");
              former.Sort((a, b) => a.BeregnAreal().CompareTo(b.BeregnAreal()));
              foreach (var form in former)
              {
                  Console.WriteLine($"Navn: {form._Name} Farge: {form._Color}, Areal: {form.BeregnAreal()}");
              }
            }


          static void FiltrerColor(List<Form> forms, string color)
          {
              Console.WriteLine();
              var filtrertFormer = forms.FindAll(form => form._Color.Equals(color, StringComparison.OrdinalIgnoreCase));
              foreach (var form in filtrertFormer)
              {
                    Console.WriteLine($"Navn: {form._Name} Farge: {form._Color}, Areal: {form.BeregnAreal()}");
                }
          }



        }
    }
}





