using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodealongØvelse
{
     class Car
    {
        public string Name { get; set; }

        public double distanceTravled { get; set; }

        public double currentspeed { get; set; }

        public double startspeed { get; set; }

        public double maxspeed { get; set; }

        public double Minspeed { get; set; }

        public Car(string name)
        {
            Name = name;
            startspeed = 0;
            maxspeed = 200.0;
            Minspeed = 10;
            currentspeed = startspeed;
            distanceTravled = 0.0;

        }

        public void Move()
        {
            if (distanceTravled < 500)
            {
                speed();
            }
            
             
            else 
                slow();

            distanceTravled += currentspeed;
        }

        public void speed()
        {
            currentspeed += 10.0;
        }

        public void slow()
        {
            if (currentspeed > Minspeed)
            {
                currentspeed -= 10.0;
            }
        }

        public bool FinnishLine()
        {
            return distanceTravled >= 1000;
        }
    }
}
