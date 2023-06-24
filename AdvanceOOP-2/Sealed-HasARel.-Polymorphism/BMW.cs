using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_HasARel._Polymorphism
{
     public class BMW : Car
     {
        private string brand = "BMW";
        public string Model { get; set; }  

        public BMW(int hP, string color) : base(hP, color)
        {
            Model = Model;
        }
        public sealed override void Repair()
        {
            Console.WriteLine($"This {brand} was repaired");
        }
    }
}
