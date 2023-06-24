using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Titanic
{    
     public class WaterCraft
     {
        public class WaterCraft(string name, int length, int passengerCapacity)
        {
            Name = name ;
            Length = length;
            PassengerCapacity {get; set;}
         }
           public string Name { get; set; }
           public int Length { get; set; }
           public int passengerCapacity { get; set; }



           public void StartEngine()
           {
               Console.WriteLine($"{Name} has started");
           }
           public void StopEngine()
           {
              Console.WriteLine($"{Name} has stopped");
           }


}
}
