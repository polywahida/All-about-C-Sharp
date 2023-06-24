using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    public class Passenger
    {
        public Passenger(string name,int floorNo,int roomNo)
        {
            Name = name;
            FloorNo = floorNo;
            RoomNo = roomNo;
        }
        public string Name { get; set; }    
        public int FloorNo { get; set;}     
        public int RoomNo { get; set;}
    }
}
