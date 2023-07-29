using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1.Factory
{
    public static class ClientCodeFactory
    {
        public static void WithoutUsingFactoryCreditCard()
        {
            string cardType = "Platinum";
            ICreditcard creditCard = null;  
            
            if(cardType == "Platinum")
            {
                creditCard = new PlatinumCreditCard();
            } 
            else if (cardType == "Titanium")
            {
                creditCard = new TitaniumCreditCard();
            }
            else if(cardType == "Gold")
            {
                //Business Logic for new card
            } else
            {
                //default one

            }
            if (creditCard !== null)
            {
                Console.WriteLine("CardType : {0}", creditCard.GetCardType());
                Console.WriteLine("CardLimit : {0}", creditCard.GetCreditLimit());
                Console.WriteLine("AnnualCharge : {0}", creditCard.GetAnnualCharge());
            }
            else 
            {
                Console.WriteLine("Invalid card type");

            }

        }
    }
}
