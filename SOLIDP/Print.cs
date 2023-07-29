using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP.SRp
{
    public class Print : ILogger1
    {
        public void Debug(string info)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(info);
        }

        public void Error(string Message, Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Message,ex.ToString());
        }

        public void Info(string info)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(info);
        }
    }
}
