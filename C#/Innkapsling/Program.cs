namespace Innkapsling
{
     class Program
    {

        /*
         1: objekt med begge variablene
        2. trekke ut metoder og flytte inn i klassej
        3. innkapsling
        4. endre implentasjon
         */


        static void Main(string[] args)
        {
            var stats = new Stats();
            while (true)
            {
                Console.Write("skriv et tall (eller blank for å avslutte)");
                var numberStr = Console.ReadLine();
                if (string.IsNullOrEmpty(numberStr)) break;
                var number = Convert.ToInt32(numberStr);
               stats.AddNumber(number);
               Console.WriteLine($"antall tall: {stats.NumberCount} " +
                                 $"sum : {stats.Sum} " +
                                 $"snitt: ${stats.Mean} ");
            }
        }
    }
}
