using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1.Prototype.ShallowDeep
{
    public class DhakaCampus : IStudents
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string University { get ; set ; }
        public string Country { get; set; }

        public IStudents GetCloneStudents()
        {
            throw new NotImplementedException();
        }

        public void ShowStudents()
        {
            Console.WriteLine("Dhaka campus student lists :: \n");
            Console.WriteLine("Name : {0}, Department {1}, University:{2},Country : ",Name,Department,University,Country);
        }
    }
}
