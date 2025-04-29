namespace Method_Overloads_og_Default_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new OverloadsOppgave("Hei og velkommen ",23,"Get Academy");
           person.PrintWelcomeMessage("Terje");

           var introtekst = new methodsAgain("hei og velkommen", "Didrik", 23);
           introtekst.Print();
        }
    }
}
