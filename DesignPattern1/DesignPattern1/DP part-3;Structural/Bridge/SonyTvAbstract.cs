using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Bridge
{
    public class SonyTvAbstract : AbstractionRemoteController
    {
        public SonyTvAbstract(ILEDTV ledtv) 
        {
            this.ledTV = ledtv;
        }
        public override void SetChannel(int channelNumber)
        {
            ledTV.SetChannel(channelNumber);
        }

        public override void switchOff()
        {
            ledTV.SwitchOff();
        }

        public override void switchOn()
        {
            ledTV.SwitchOn();
        }
    }
}
