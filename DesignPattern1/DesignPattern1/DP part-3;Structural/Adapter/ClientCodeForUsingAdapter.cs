using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Adapter
{
    public static class ClientCodeForUsingAdapter
    {
        public static void UsedAdapter()
        {
            string[,] employessArray = new string[5, 2];
            {

                { "Poly","500000"},
                { "Rajit","600000"},
                { "Adil","700000"},
                { "Labib","800000"},
                { "Moinul","900000"},

            };
            Console.WriteLine("Process Salary");
            IAdapter employAdapter = new EmployeAdapter();
            employAdapter.AdaptMatrixData(employessArray);
        }
    }
}
