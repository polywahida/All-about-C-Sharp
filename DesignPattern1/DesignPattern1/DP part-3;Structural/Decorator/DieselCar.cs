using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Decorator
{
    internal class DieselCar : CarDecorator
    {
        public DieselCar(ICar car) : base(car)
        {
        }
        public override ICar ManufacturCar()
        {
            car.ManufacturCar();
            AddEngine(car);
            return car;

        }

        public void AddEngine(ICar car)
        {
            if (car is BMWCar BMW)
            {
                BMW.Engine = "Diesel Engine";
                Console.WriteLine("Diesel engine Added to the Car : " + car);
            }
        }
    }
}
