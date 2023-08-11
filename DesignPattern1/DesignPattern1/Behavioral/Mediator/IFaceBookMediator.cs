using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Mediator
{
    internal interface IFaceBookMediator
    {
        protected User(string Name)
        {
            Name = Name;
        }
       public abstract void SendMessage(string msg, User user);

    }
}
