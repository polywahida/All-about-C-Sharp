using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1.Factory
{
    public class TitaniumCreditCard : ICreditcard
    {
        public int GetAnnualCharge()
        {
            return 600;
        }

        public string GetCardType()
        {
            return "Titanium credit card";
        }

        public int GetCreditLimit()
        {
            return 1500000;
        }
    }
}
