using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using øvelsecodealongOppgave;

namespace Bygghus
{
    public class Floor
    {
        public string Name { get; set; }
        public List<Room> rooms { get; set; }  
        public int FloorNumber { get; set; }
        public Floor(int floorNumber, string name )
        {

            Name = name;
            FloorNumber = floorNumber;
            rooms = new List<Room>();
        
        }

        public Floor()
        {
            
        }

    public void addRoom(string Userinput)
        {
            if (rooms.Count >= 5)
            {
                Console.WriteLine($"du kan ikke legge til flere room i {FloorNumber}");
                return; 
            }

            if (Userinput == "Bad" && rooms.Any(x => x.Name == "Bad"))
            {
                Console.WriteLine("Det kan ikke være mer enn 1 bad per etasje");
                return;
            }
            if (Userinput == "Kjøkken" && rooms.Any(x => x.Name == "Kjøkken"))
            {
                Console.WriteLine("Det kan ikke være mer enn 1 kjøkken per etasje.");
                return;
            }

            var room = new Room(Userinput);
            rooms.Add(room);
            Console.WriteLine();
            Console.WriteLine($"{room.Name} er lagt til i {FloorNumber}, etasje");
    }
}
}

  

