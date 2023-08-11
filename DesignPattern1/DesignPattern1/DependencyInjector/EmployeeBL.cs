using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjector
{
    internal class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;

        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }

        public List<Employee>GetAllEmployee()
        {
            return employeeDAL.SelectAllEmployess();
        }
    }
}
