using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP
{
    public class OrangeDerivedClass : AppleBaseClass  
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
