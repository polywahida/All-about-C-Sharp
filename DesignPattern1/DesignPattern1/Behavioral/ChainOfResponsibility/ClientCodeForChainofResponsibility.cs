using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    public static class ClientCodeForChainofResponsibility
    {
        public static void UseChainofResponsibility()
        {
            Twothousand twothousand = new Twothousand();
            FiveHundredHadler fiveHundredHadler = new FiveHundredHadler();
            TwohundredHandler twohundredHandler = new TwohundredHandler();
            Hundred hundred = new Hundred();


            twothousand.SetNextHandler(FiveHundredHadler);
            fiveHundredHadler.SetNextHandler(twohundredHandler);
            twohundredHandler.SetNextHandler(twohundredHandler);

            var requestAmount = 65965;
            if(requestAmount%100==0)
            {
                twothousand.DispatchMoney(requestAmount);

            }
            else
            {
                Console.WriteLine("You enter invalid amount:");
            }
        }

    }
}
