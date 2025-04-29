using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloads_og_Default_values
{
   public class OverloadsOppgave
   {
       public string introMessage;

       public int age;

       public string workplace;


       public OverloadsOppgave(string IntroMessage)
       {
           introMessage = IntroMessage;
       }

        public OverloadsOppgave(string IntroMessage, int Age)
       {
           introMessage = IntroMessage;
           age = Age;
       }

       public OverloadsOppgave(string IntroMessage, int Age, string Workplace

       )
       {
           introMessage = IntroMessage;
           age = Age;
           workplace = Workplace;
       }

       
       public void PrintWelcomeMessage (string extrainfo = "Terje")
       {
           Console.WriteLine(introMessage + extrainfo);
        }
    }
}
