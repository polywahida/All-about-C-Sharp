using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMulticast
{
    public class MachineManager
    {

        public delegate void MachineEvent();
        public static MachineEvent? OnStartMachine, OnStopMachine;
        public static void TriggerOnStart()
        {
            if(OnStartMachine != null)
            {
                Console.WriteLine("The below machines are starting....");
                OnStartMachine();
            }
        }
        public static void TriggerOnStop() 
        { if(OnStopMachine != null) 
            {
                Console.WriteLine("The below machines are stoping....");
                OnStopMachine();
            }
        }
    }
}
