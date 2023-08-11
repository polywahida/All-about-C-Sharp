using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Bridge
{
    public class SamsungTV : ILEDTV
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting Channel Number "+ channelNumber + "On Samsung tv");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Samsung tv");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Samsung tv");
        }
    }
}
