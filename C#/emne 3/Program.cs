// See// See https://aka.ms/new-console-template for more information
 namespace test
 {
 internal class WhatsYourName
 {
 
 static void PrintToConsole()
 {
 Console.WriteLine("Denne metoden returnerer ingenting");
 }
 static void Main()
 {
 PrintToConsole();
 Console.WriteLine("Hva heter du?");
 string? inputName = Console.ReadLine();
 Console.WriteLine("Hva gammel er du?");
 string? inputAge = Console.ReadLine();
 Console.WriteLine("Hvor bor du?");
 string? inputWhere = Console.ReadLine();
 Console.WriteLine($"Du heter {inputName}, er {inputAge} år gammel og kommer fra {inputWhere}.");
 }
 }
 }
 