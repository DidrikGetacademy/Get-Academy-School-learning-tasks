using System;

class UtenInnkapsling
{
    public string navn;
    public int alder;

    public UtenInnkapsling(string n, int a)
    {
        navn = n;
        alder = a;
    }
}

class Program
{
    static void Main()
    {
        UtenInnkapsling person = new UtenInnkapsling("John", 25);

        Console.WriteLine("Navn: " + person.navn);
        Console.WriteLine("Alder: " + person.alder);

        person.alder = 30; // Direkte tilgang til feltet alder uten begrensninger
        person.navn = "Bjarne";
        Console.WriteLine("ny navn " + person.navn);
        Console.WriteLine("Ny alder: " + person.alder);

    }
}

/*
Selvfølgelig! Innkapsling er en av de fire grunnleggende prinsippene i 
objektorientert programmering (OOP), 
sammen med arv,
polymorfi og abstraksjon. La oss se på noen enkle eksempler i C#:
Uten innkapsling:


I det første eksemplet har vi direkte tilgang til feltene navn og alder uten noen form for begrensning.

 */