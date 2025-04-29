using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace øving
{
   public class Floor
    {
        public List<Floor> floors { get; set; }
        public List<Room> _FloorRooms { get; set; } 
        public int _RoomCount { get; set; }
        public int _FloorCount { get; set; }

        public Floor()
        {
            floors = new List<Floor>();
            _FloorRooms = new List<Room>();
            _RoomCount = 0;
            _FloorCount = 1;
 
        }

          public  void addRoomsToFloor()
            {
            while(_RoomCount < 5)
            {
                Console.WriteLine("Rom Navn: ");
                var name = Console.ReadLine();
                var room = new Room(name);
                _FloorRooms.Add(room);
                _RoomCount++;
                Console.WriteLine($"Du har [{_RoomCount}] rom i {_FloorCount} Etasje");



                if (_RoomCount == 5)
                {
                    var floor = new Floor();
                    floors.Add(floor);

                    Console.WriteLine($"Du har lagt til {_RoomCount} rom, {_FloorCount} etasje er ferdig!");
                    _FloorCount++;
                    Console.WriteLine("Trykk enter for å starte på neste etasje!");
                    Console.ReadLine();
                    Console.Clear();
                
            
                }
            }

         
        }

    }
}
