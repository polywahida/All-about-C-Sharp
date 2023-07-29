using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1.Prototype
{
    public class Students
    {
        public string Name {  get; set; }
        public string Department { get; set; }
        public string University { get; set; }
        public static void UseWithProto()
        {

            //Memory Address
            Students moinul = new Students();
            moinul.Name = "Moinul";
            moinul.Department = "CSE";
            moinul.University = "UIU";
            
            
            moinul.GetCloneStudents();
            Students poly = moinul;
            poly.Name = "Poly";

            Console.WriteLine("Moinul");
            Console.WriteLine("Name : {0}, Department : {1}, University : {2}", moinul.Name, moinul.Department, moinul.University);


            Console.WriteLine("Poly");
            Console.WriteLine("Name : {0}, Department : {1}, University : {2}", poly.Name, poly.Department, poly.University);
        }
    }
}
