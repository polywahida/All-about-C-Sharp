using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Facade
{
    internal class CustomerDataAccessLayer
    {
        public bool SaveCustomer(Customer customer)
        {
            Console.WriteLine("\n Customer Saved into database...");
            return true;
        }
    }
}
