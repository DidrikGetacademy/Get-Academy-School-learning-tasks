using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace CodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<rom> romList = new List<rom>();
            var rom1 = new rom("Kjøkken");
            var rom2 = new rom("soverom");
            var rom3 = new rom("Bad");
            var rom4 = new rom("stue");
            romList.Add(rom1);
            romList.Add(rom2);
            romList.Add(rom3);
            romList.Add(rom4);

            var etasje1 = new etasje(1);
            int listCount = 0;
            int count = 0;
            bool program = true;




            while (program) 

            {
                foreach (var rom in romList)
                {
                    listCount++;
                    Console.WriteLine($"{listCount}.Rom: {rom.Name}");
                    if (listCount == 4)
                    {
                        listCount = 0;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("velg ønsket rom");
                var userinput = Console.ReadLine();
                Console.WriteLine();
             


                if (count == 5)
                {
                    Console.WriteLine("huset er ferdig  du har nå lagt til disse rommene");

                    foreach (var room in etasje1.Romnavn)
                    {
                        Console.WriteLine($"{room.Name}");
                    }

                     program = false;
                }

                

                switch (userinput)
                {
                    case "1":
                        etasje1.Romnavn.Add(rom1);
                        Console.WriteLine($"du la til {rom1.Name}");
                        Console.WriteLine();
                        count += 1;
                        Console.WriteLine($"Du har nå {count} rom i denne etasjen ");
                        romList.Remove(rom1);
                       
                        break;
                
                    case "2":
                        etasje1.Romnavn.Add(rom2);
                        Console.WriteLine($"du la til {rom2.Name}");
                        count += 1;
                        Console.WriteLine($"Du har nå {count} rom i denne etasjen ");
                   
                        break;

                    case "3":
                        etasje1.Romnavn.Add(rom3);
                        Console.WriteLine($"du la til {rom3.Name}");
                        count += 1;
                        Console.WriteLine($"Du har nå {count} rom i denne etasjen ");
                        romList.Remove(rom3);
                       
                        break;

                    case "4":
                        etasje1.Romnavn.Add(rom4);
                        Console.WriteLine($"du la til {rom4.Name}");
                        count += 1;
                        Console.WriteLine($"Du har nå {count} rom i denne etasjen ");
                        break;

                        
                }

            }
        }
    }
}
/*
 
 Lag en app som kan bygge et hus. Et hus kan bestå av etasjer og rom.
Brukeren skal kunne velge hva slags type rom den vil legge til om det er bad,
kjøkken, soverom eller stue.
Et hus er ikke ferdig før hver etasje består av nøyaktig 5 rom, og det kan ikke være flere enn 1 bad eller 1 kjøkken pr etasje. Når huset er
ferdig, skal applikasjonen printe ut informasjon om hvilke rom huset består av.
 */