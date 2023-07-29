using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1.Prototype.ShallowDeep
{
    public interface IStudents
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string University { get; set; }
        public Address Country { get; set; }    

        public IStudents GetCloneStudents();

        public void ShowStudents();

    }
}
