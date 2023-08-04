using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Decorator
{
    public class BMWCar : ICar
    {
        private string CarName = "BMW";
        public string CarColor {  get; set; }
        public string Engine { get; set; }
        public ICar ManufacturCar()
        {
            CarColor = "Carbon Fiber Material";
            return this;
                
        }
        public override string ToString()
        {
            return "BMWcar [CarName = "+CarName+",CarBody = " + CarBody + " Car Engine = "+Engine+"  ]";
        }
    }
}
