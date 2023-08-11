using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Mediator
{
    public class ConcreteFBgroupMediator : IFaceBookMediator
    {
        private List<User> userList = new List<User>();

        public void RegisterUser(User user)
        {
           userList.Add(user);
            user.Mediator = this;
        }

        public void SendMessage(string msg, User user)
        {
           foreach(User user in userList) 
            
           {
                if (user != use)
                {
                    user.Receive(msg);
                }
            
           }
        }
    }
}
