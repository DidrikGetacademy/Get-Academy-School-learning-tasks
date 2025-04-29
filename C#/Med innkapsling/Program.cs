
using System;


/*
 
   Nesten riktig! Når du bruker private set i en egenskap (property) i C#,
betyr det at du kan sette verdien innenfor samme klasse, men ikke utenfor. 
Du kan fremdeles endre verdien fra Program.cs ved å bruke en metode i klassen som har tilgang til den private egenskapen.
Her er et eksempel:
 */
class MedPrivateSet
{
    private string navn;

    public MedPrivateSet(string n)
    {
        Navn = n;
    }

    public string Navn
    {
        get { return navn; }
        private set { navn = value; }
    }

    public void EndreNavn(string nyttNavn)
    {
        // Metoden i klassen kan endre den private egenskapen
        Navn = nyttNavn;
    }
}

class Program
{
    static void Main()
    {
        MedPrivateSet objekt = new MedPrivateSet("John");

        Console.WriteLine("Navn: " + objekt.Navn);

        // objekt.Navn = "NyJohn"; // Dette gir en feil på grunn av private set

        objekt.EndreNavn("NyJohn");

        Console.WriteLine("Nytt navn: " + objekt.Navn);
    }
}

/*
 using System;
   
   class MedInnkapsling
   {
   private string navn;
   private int alder;
   
   public MedInnkapsling(string n, int a)
   {
   Navn = n;
   Alder = a;
   }
   
   public string Navn
   {
   get { return navn; }
   set { navn = value; }using System;

class MedPrivateSet
{
    private string navn;

    public MedPrivateSet(string n)
    {
        Navn = n;
    }

    public string Navn
    {
        get { return navn; }
        private set { navn = value; }
    }

    public void EndreNavn(string nyttNavn)
    {
        // Metoden i klassen kan endre den private egenskapen
        Navn = nyttNavn;
    }
}

class Program
{
    static void Main()
    {
        MedPrivateSet objekt = new MedPrivateSet("John");

        Console.WriteLine("Navn: " + objekt.Navn);

        // objekt.Navn = "NyJohn"; // Dette gir en feil på grunn av private set

        objekt.EndreNavn("NyJohn");

        Console.WriteLine("Nytt navn: " + objekt.Navn);
    }
}

   }
   
   public int Alder
   {
   get { return alder; }
   set
   {
   if (value >= 0)
   alder = value;
   else
   Console.WriteLine("Alder kan ikke være negativt!");
   }
   }
   }
   
   class Program
   {
   static void Main()
   {
   MedInnkapsling person = new MedInnkapsling("John", 25);
   
   Console.WriteLine("Navn: " + person.Navn);
   Console.WriteLine("Alder: " + person.Alder);
   
   // person.Alder = -5; // Dette vil gi en feilmelding på grunn av innkapsling
   
   person.Alder = 30;
   
   Console.WriteLine("Ny alder: " + person.Alder);
   }
   }


// I dette  eksemplet bruker vi innkapsling ved å bruke private felt og offentlige egenskaper (Navn og Alder).
   // Dette gir bedre kontroll over tilgangen til dataene,
   // for eksempel ved å legge til validering i setter-metoden.
   
 */