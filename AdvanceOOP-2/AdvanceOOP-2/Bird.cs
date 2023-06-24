using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP_2
{
    internal class Bird : IAnimal
    {
        public void Move
        { 
            console.WriteLine("Flying is the sky");
          }
        void IAnimal.MakeSound
        { 
            Console.WriteLine("Chrip");
        }
    }
}
