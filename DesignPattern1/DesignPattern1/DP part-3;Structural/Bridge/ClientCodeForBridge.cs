using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Bridge
{
    public static class ClientCodeForBridge
    {
        public static void UseBridgePattern()

        AbstractionRemoteController sonyRemotecontrol = new SonyTvAbstract(new SonyTv());
        sonyRemotecontrol.SwitchON();
            sonyRemotecontrol.SetChannel(401);
            sonyRemotecontrol.SwitchFF();

            Console.WriteLine("Samsung TV");
            AbstractRemoteController samsungRemoteControl = new SamsungTvAbstract(new SonyTv);
               samsungRemotecontrol.SwitchON();
              samsungRemotecontrol.SetChannel(401);
               samsungRemotecontrol.SwitchFF();


    }
          
}

