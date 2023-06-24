using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP_2
{
    public class DOg : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }

        public void Move() 
        { 
           Console.WriteLine("Running on four legs");
        }
    }
}
