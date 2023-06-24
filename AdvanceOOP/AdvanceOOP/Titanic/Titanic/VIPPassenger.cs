using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    internal class VIPPassenger: Passenger , ISinkAble 
    {  public VIPPassenger(string name, int floorNo, int roomNo) : base(name, floorNo, roomNo) 
        { 

        }

        int ISinkAble.SinkDuration { get ; set ; }

        void ISinkAble.Sink()
        {
            throw new NotImplementedException();
        }
    }
}
