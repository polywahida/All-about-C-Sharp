using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Bridge
{
    public abstract class AbstractionRemoteController
    {
        protected ILEDTV ledTV;
        public abstract void switchOn();
        public abstract void switchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
