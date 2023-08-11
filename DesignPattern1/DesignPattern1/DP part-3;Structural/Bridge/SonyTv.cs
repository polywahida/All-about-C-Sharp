using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Bridge
{
    public class SonyTv : ILEDTV
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting Channel Number " + channelNumber + "On Sony tv");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Sony tv");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning ON  : Sony tv");
        }
    }
}
