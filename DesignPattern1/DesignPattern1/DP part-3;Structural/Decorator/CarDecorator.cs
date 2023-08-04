using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Decorator
{
    public abstract class CarDecorator : ICar
    {
        protected ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public ICar ManufacturCar()
        {
            return car.ManufacturCar;
        }
    }
}
