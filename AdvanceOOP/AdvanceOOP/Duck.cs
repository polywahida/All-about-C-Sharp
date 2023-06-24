using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceOOP
{    
    //Is-A (Relationship)
    //Duck is a Bird

    public class Duck: Birdparent
    {
        public bool isFly { get; set; } = true;
        public Duck(string name,string color,string diet) :base(name,color,diet){ 
        }

        public override void Fly()
        { Console.WriteLine($"{Name} Can not fly");
        //  base.Fly(); 
        }
         
    }


}
