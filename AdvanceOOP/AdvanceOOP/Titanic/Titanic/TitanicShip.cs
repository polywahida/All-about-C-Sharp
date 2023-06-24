using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    public class TitanicShip : WaterCraft , ISinkAble 
    {
        private object Length;

        public TitanicShip(String name, int length,int passangerCapacity)
        {
            SinkDuration = passangerCapacity - 10;


        }
        public int sinkDuration {  get; set; }
        public void Sink()
        {
            Console.WriteLine($"The watercraft {Name} is sinking,which is {Length} units big.");
            Console.WriteLine($"The watercraft {Name} will sink in {sinkDuration} minutes.");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Now everything inside {Name} will sink");
        }
        int ISinkAble.SinkDuration { get ; set ; }

        void ISinkAble.Sink()
        {
            throw new NotImplementedException();
        }

      


    }
}
