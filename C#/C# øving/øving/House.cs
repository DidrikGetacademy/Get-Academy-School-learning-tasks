using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace øving
{
    public class House
    {

        public Floor Floors{ get; set; }
   
        public House()
        {
            Floors = new Floor();
        }



        public void Build()
        {
            while (floors.Count <= 3)
            {
                var floor = new Floor();
                floor.addRoomsToFloor();
                floors.Add(floor);
         

            }
      
        }



    



        void PrintHouse()
        {
            foreach (var floor in  floors)
            {
                Console.WriteLine($"Etasje: [{floor._FloorCount}]");
                foreach (var room in floor._FloorRooms)
                {
                    Console.WriteLine($"Romnavn: {room._Name}");
                }
            }




        }
    }
}


  





