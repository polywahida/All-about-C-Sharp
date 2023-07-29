using SOLIDP.OpenClass;
using SOLIDP.SRp;

namespace SOLIDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // var invoice = new InvoiceClass("DummyName","DummyDescription",4);
            //invoice.AddInvoice();
            //var amount = OCInvoice.GetInvoiceDiscount(4000, InvoiceType.FinalInvoice);
            //Console.WriteLine(amount);
            InvoiceOP fiInvoice = new FinalInvoice();
            double finalInvoiceamount = fiInvoice.GetInvoiceDiscount(500);
            Console.WriteLine("Final Invoice amount :{0}", finalInvoiceamount);
        }
    }
}