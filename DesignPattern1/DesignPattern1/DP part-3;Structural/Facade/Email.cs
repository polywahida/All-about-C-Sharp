using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Facade
{
    public class Email
    {
        public bool SendResgistrationEmail(Customer customer)
        {
            Console.WriteLine("Registration email send");
            return true;
        }
    }
}
