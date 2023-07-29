using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1.Factory
{
    public interface ICreditcard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
