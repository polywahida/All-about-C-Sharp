using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Facade
{
    public class Validator
    {
        public bool ValidateCustomer(Customer Customer)
        {
            Console.WriteLine("Customer validated...");
            Console.WriteLine("Name: {0}", Customer.Name);
            Console.WriteLine("Email : {1}", Customer.Email);
            return true;
        }
    }
}
