using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoleøving
{
     class Car
     {
       public string Name { get; set; }

       public double startSpeed { get; set; }   

       public double MinSpeed { get; set; } 

       public double MaxSpeed { get; set; } 

       public double distancetravled { get; set; }  

       public double CurrentSpeed { get; set;  }

       public Car(string name)
       {
           Name = name;
           startSpeed = 10.0;
           MinSpeed = 10.0;
           MaxSpeed = 200.0;
           distancetravled = 0.0;
           CurrentSpeed = startSpeed;
       }


       public void move()
       {
           if (distancetravled < 500.0)
           
               speed();
           
           else
           
               slow();

           distancetravled += CurrentSpeed;
       }


       public void speed()
       {
           CurrentSpeed += 10.0;
       }

       public void slow()
       {
           if (CurrentSpeed > MinSpeed)
           {
               CurrentSpeed -= 10.0;
           }
       }

       public bool finnishLine()
       {
           return distancetravled >= 1000;
       }
     }


}
