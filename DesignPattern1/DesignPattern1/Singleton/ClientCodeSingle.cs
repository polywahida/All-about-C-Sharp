using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1.Singleton
{
    public static class ClientCodeSingle
    {
        public static void UseSingletonWithoutThreadSafeAndLazyLoading()
        {
            SingletonNoThreadSafe fromTeacher = SingletonNoThreadSafe.GetInstance();
            fromTeacher.ShowDetails("From Teacher");
            SingletonNoThreadSafe fromStudents = SingletonNoThreadSafe.GetInstance();
            fromTeacher.ShowDetails("From Students");
        }
        public static void UseMultithreadProgram()
        {
            Parallel.Invoke();

        }

        private static void PrintTeacherDetails()
        {
            SingletonNoThreadSafe fromTeacher = SingletonNoThreadSafe.GetInstance();
            fromTeacher.ShowDetails("From Teacher");
        }
    }

}
