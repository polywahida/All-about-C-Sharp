using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_HasARel._Polymorphism
{
     public class Audi : Car
     {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi(int hP, string color) : base(hP, color)
        {
            Model = model;
        }
        public void new showDetails()
        {
            Console.WriteLine($"Brand : {brand},HP: {HP},Color: {Color}");
        }
        public override void Repair()
        {
            Console.WriteLine($"This {brand} was repaired");
        }



      
     }
}
