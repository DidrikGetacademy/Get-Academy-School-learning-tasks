namespace Emne3Demo2
{
    internal class MyConsole
    {
        public static string Ask(string question)
        {
            Console.Write(question);
            var answer = Console.ReadLine();
            return answer;
        }

        public static int AskForInt(string question)
        {
            var answer = Ask(question);
            return Convert.ToInt32(answer);
        }

        public static bool AskForBool(string question)
        {
            var answer = Ask(question);
            return answer.ToLower() == "j";
        }
    }
}