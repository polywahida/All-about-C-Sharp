using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    public class FiveHundredHadler : Handler
    {
        public override void DispatchMoney(long requestedAmount)
        {
            long numberNotesTobDispatched = requestedAmount / 500;

            if (numberNotesTobDispatched > 0)
            {
                if (numberNotesTobDispatched > 1)
                {

                    Console.WriteLine(numberNotesTobDispatched + "Five hundred noted are dispatched by twothousandHanlder");


                }
                else
                {
                    Console.WriteLine(numberNotesTobDispatched + "Five hundred noted are dispatched by twothousandHanlder");

                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 500;
            if (pendingAmountToBeProcessed > 0)
            {
                NextHandler.DispatchMoney(pendingAmountToBeProcessed);
            }
        }
    }
}
