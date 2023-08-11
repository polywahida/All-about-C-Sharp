using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Mediator.NewFolder
{
    public class ClientCodeForMediator
    {
        public static void UseMediator()
        {
            IFaceBookMediator facebookMediator = new ConcreteFBgroupMediator();

            User poly = new ConcreteUser("Poly");
            User moinul= new ConcreteUser(" moinul");
            User rajit = new ConcreteUser("Rajit");

            techByteFacebookGroup.RegisterUser(Poly);


        }
    }
}
