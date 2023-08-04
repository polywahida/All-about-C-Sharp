using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Decorator
{
    public static class ClientCodeForDecorator 
    {
        public static void UseDecoratorCode()
        {
            ICar bmwCar1 = new BMWCar();

            //bmwCar1.ManufacturCar();
            //Console.WriteLine(bmwCar1 + "\n");

            DieselCar carWithDieselEngine = new DieselCar(bmwCar1);
            carWithDieselEngine.ManufacturCar();
            Console.WriteLine();
        }
    }
}
