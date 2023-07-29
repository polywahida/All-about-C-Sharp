using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP
{
    internal interface ILogger1
    {
        void Info(string info);
        void Debug(string info);
        void Error(string Message, Exception ex);

    }
}
