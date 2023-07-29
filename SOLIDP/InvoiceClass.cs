using SOLIDP.SRp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP.SRp
{
    public class InvoiceClass
    {
        public string InvoiceName { get; set; }
        public string InvoiceDescription { get; set;}
        public int OrderId { get; set; }
        private Email emailSender;

        public InvoiceClass(string invoiceName, string invoiceDescription, int orderId)
        {
            InvoiceName = invoiceName;
            InvoiceDescription = invoiceDescription;
            OrderId = orderId;
            this.emailSender = new Email();
            this.print = new Print();
        }

        
        public void AddInvoice()
        {
            try
            {
                this.Print.Info();
                Console.WriteLine("Your Invoice is creating");
                if(string.IsNullOrEmpty(InvoiceName))
                {
                    Console.WriteLine("Invoice is read to send");
                }
                MailMessage malMessage = new MailMessage("EmailFrom","EmailTo","Invoice","YourInvoiceBody");
                this.emailSender.SendEmail(malMessage);
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
      
}
