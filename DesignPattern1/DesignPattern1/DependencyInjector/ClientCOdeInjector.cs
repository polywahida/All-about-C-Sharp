using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjector
{
    internal class ClientCOdeInjector
    {
        public static void UserInjectors()
        {
            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());

            List<Employee> listOfEmployee = employeeBL.GetAllEmployee();
            foreach (Employee employee in listOfEmployee)
            {


            }
        }
    }
}
