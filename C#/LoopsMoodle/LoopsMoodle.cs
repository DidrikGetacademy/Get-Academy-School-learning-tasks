    namespace LoopsMoodle
{
    internal class LoopsMoodle
    {
        public void Run()
        {

            bool condition = true;
            int i = 0;

            while (condition)
            {
                if (i > 10)
                {
                    condition = false;
                }
                else
                {
                    Console.WriteLine("runde nr" + i);
                    i++;
                }

            }






             void forloop()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Terje er kul");
                }
            }





          void foreachLoop()
            {
                string tekst = "Didrik";

                foreach (char bokstav in tekst)
                {
                    Console.WriteLine(bokstav);
                }
            }

            
        }
    }
}


                
            
        
    



