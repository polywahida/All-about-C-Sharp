using DesignPatternPart1and2.Structural.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Adapter
{
    public class EmployeAdapter : IAdapter
    {
        ThirdPartyBilingSystem  thirdPartyBillingSystem = new ThirdPartyBilingSystem();
        public void AdaptMatrixData(string[,] employeesArray)
        {
            string Name = null;
            string Salary = null;

            List<Employee> listEmployee = new List<Employee>();
            thirdPartyBillingSystem.processSalary(listEmployee);
        }
    }
}
