using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP part-3;Structural.Adapter
{
    public class Employee
    {
        public Employee(string id, string name, string designation, string salary)
        {
            Id = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Salary { get; set; }
    }
}
