using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatyper.cs
{
  public  class Variabler
    {

        // variabel klasser
       public  int heltall = 1;
       public long langtTall = 10000000000;
       public float desimalTall = 1.01F; // nøyaktig.
       public decimal desimalTall3 = 1.01M; // veldig nøyaktig.
       public double desimalTall2 = 1.01;
       public string tekst = "Hei";
       public char a = 'a';
       public bool santUsant = true; // eller false.


       public void Run() //oppgave 1
       {
      // skriver ut variablene fra variabler-klassen
           Console.WriteLine($"int: {heltall}");
           Console.WriteLine($"long: {langtTall} ");
           Console.WriteLine($"float: {desimalTall}");
           Console.WriteLine($"decimal: {desimalTall3}");
           Console.WriteLine($"double: {desimalTall2}");
           Console.WriteLine($"string: {tekst}");
           Console.WriteLine($"char: {a}");
           Console.WriteLine($"bool: {santUsant}");
        }


       public void RunOppgave2() //oppgave 2
       {
           int a = 5;
           decimal b = 3.0m;// m merker at dette er en decimal
           decimal sum = a + b;

           //skriv ut resultat til console
           Console.WriteLine($"Int variabel: {a} ");
           Console.WriteLine($"decimal variabel: {b}");
           Console.WriteLine($"sum: {sum}");

       }
    }
}
    





//Tips
///////////////////////////////////////////////////
public void DenneFunksjonenReturnererIngenting()
 {
 return;
 }



//Hvis det er en spesifikk datatype den skal returnere, så må det defineres slik: 
 public int DenneFunksjonenReturnererEtHeltall()
 {
 int etTall = 5;
 return etTall;
 }


public int DenneFunksjonenTarInnToTall(int input1, int input2)
{	 
 return input1 + input2; //her returneres summen av de to tallene sendt inn i metoden
 }