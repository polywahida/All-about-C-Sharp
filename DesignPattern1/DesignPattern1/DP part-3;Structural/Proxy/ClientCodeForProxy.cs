using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Proxy
{
    public class ClientCodeForProxy
    {
        public static void UseProxyPattern()
        {
            Employee emp1 = new Employee("Riyad", "CEO");

            SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);

            folderProxy1.PerforRWOperation();

            Console.WriteLine(); 

        }

    }
}
