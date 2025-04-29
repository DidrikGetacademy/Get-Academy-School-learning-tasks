using System.Security.Cryptography.X509Certificates;

namespace Objektorientering
{
     class Program
    {
        static void Main(string[] args)
        {

            // Javascript: var x = {width: 50, height: 30 };
            // C#          var x = new {Width = 50, Height = 30};

            // Men DETTE er sånn det skal gjøres i C# - det over er bare unntaksvis
            var x = new Box { Width = 50, Height = 30 };
            x.Show();
        }
    }
}
