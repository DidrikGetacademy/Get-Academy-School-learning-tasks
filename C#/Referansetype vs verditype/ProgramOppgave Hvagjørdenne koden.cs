namespace Referansetype_vs_verditype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine().ToUpper().ToLower();
            
                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        double percentage = text.Length > 1 ? ((double)counts[i] / text.Length) * 100 : 1;

                        string formattedPercentage = percentage.ToString("F2").PadLeft(10);
                        Console.WriteLine(character + " - " + formattedPercentage + "%");
                    }
                }
            }
        }
    }
}

// 3. Endre det så det håndterer store og små bokstaver likt (bruk google/stackoverflow.com)
// 
// 4. Tell i prosent
// 
// 5. Skriv ut tall høyrejustert, se eksempel:
// 
// 1
// 20
// 300