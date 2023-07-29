using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1.Factory
{
    public class PlatinumCreditCard : ICreditcard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Platinum Credit Card";
        }

        public int GetCreditLimit()
        {
            return 1500000;
        }
    }
}
