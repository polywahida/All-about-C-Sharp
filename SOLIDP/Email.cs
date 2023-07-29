using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP.SRp
{
    public class Email
    {
        public void SendEmail(MailMessage malMessage)
        {
            try
            {
                Console.WriteLine("Email is sending");
                //this will be email code send 
                Console.WriteLine("Email has sent");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
