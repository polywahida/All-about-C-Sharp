using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPart1and2.DP_part_3_Structural.Facade
{
    public class ClientCodeForFacade
    {
        public static void WithFacade()
        {
            Customer customer = new Customer
            {
                Name = "Poly";
            Email = "poly@gmail.com"

             CustomerRegistration customerRegistration = new CustomerRegistration();
            customerRegistration.RegisterCustomer(customer);





                 };
    }
        //Validator validator = new Validator();
        //bool IsValid = Validator.ValidateCustomer(customer);

        //    if (IsValid)
        //    

        //        CustomerDataAccessLayer customerDataAccessLayer = new CustomerDataAccessLayer();
        //bool IsSaved = CustomerDataAccessLayer.SaveCustomer(customer);

        //        if (IsSaved)
        //        
        //            Email email = new Email();
        //           Email.SendRegistrationEmail();
        //     }
        










    }

}


}






        
    
   

