using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.Structural.Adapter
{
    internal class ThirdPartyBilingSystem
    {
        public void processSalary(List<Employee> employees)
        {
            foreach (var employe in employees)
            {
                Console.WriteLine("Euros {0} has credited to {1} account",employe.Salary,employe.Name);

            }
        }
    }
}
