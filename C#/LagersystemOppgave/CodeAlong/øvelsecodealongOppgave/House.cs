using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Bygghus;

namespace øvelsecodealongOppgave
{
    public class House
    {

        public List<Floor> HouseFloor { get; set; }

        public House()
        {
         HouseFloor = new List<Floor>();
   
        }

     
        public void Build()
        {
            int Count = 6;
            Console.WriteLine();

            for (int i = 1; i <= 2; i++)
            {
                var floor = new Floor(i, $"etasje {i}");
                HouseFloor.Add(floor);

                while (floor.rooms.Count < 5)
                {

                     Console.WriteLine($"legg til ønsket rom i {floor.FloorNumber}. etasje");
                    var Userinput = Console.ReadLine();
                    floor.addRoom(Userinput);
                }
            }
            Console.WriteLine("Huset er ferdig bygget!");
            PrintHouseInfo();
        }

        public void PrintHouseInfo()
        {
            foreach (var floor in HouseFloor)
            {
                Console.WriteLine();
                Console.WriteLine($"{floor.Name}");
                foreach (var room in floor.rooms)
                {
                    Console.WriteLine($"-{room.Name}");
                }
            }
        }
     
    }
}
