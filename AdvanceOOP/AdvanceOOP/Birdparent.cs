using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP
{
    public class Birdparent
    {
        public string? Name { get; set; }
        public string? Color { get; set; }
        public string? Diet { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} eats {Diet}");
        }
         //override
        public virtual  void Fly()
        {
            Console.WriteLine($"{Name} can fly");
        }
         public void FlyBird()
        {
            Console.WriteLine($"{Name} can fly");
        }
    }
}
