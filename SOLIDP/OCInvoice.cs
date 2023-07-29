using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP

{
    public enum InvoiceType
    {
        FinalInvoice,
        ProposedInvoice,
        NewInvoice
    }
    public class OCInvoice
    {
        public static double GetInvoiceDiscount(double amount,InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if(invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount- 100;

            }else if(invoiceType== InvoiceType.ProposedInvoice)
            {
                finalAmount = amount- 50;
            }else if(invoiceType == InvoiceType.NewInvoice)
            {

            }
            return finalAmount;
        }

    }
}
