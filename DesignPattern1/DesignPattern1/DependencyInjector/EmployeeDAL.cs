using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjector
{
    public class EmployeeDAL : IEmployeeDAL
    {
         public List<Employee> IEmployeeDAL.SelectAllEmployess()
         {
            List<Employee> listEmployees = new List<Employee>()
            {
               new Employee() {ID =1, Name ="Riyad",Department="ProjectManagement"};

            new Employee() { ID = 2, Name = "Moinul", Department = "operation" };
            new Employee() { ID = 1, Name = "Adil", Department = "software" };
         }
       
    }
}

