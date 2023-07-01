using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMulticast
{
    public class Oven
    {
        public string OvenName { get; set; }

        public Oven(string ovenName)
        {
            OvenName = ovenName;
            MachineManager.OnStartMachine += StartMachine;
            MachineManager.OnStopMachine += StopMachine;

        }
        private void StartMachine()
        {
            Console.WriteLine($"{OvenName} has started!");
        }

        private void StopMachine()

        {
            Console.WriteLine($"{OvenName} has stopped!");

        }
    }
}
