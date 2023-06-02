using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Methods
{
    public class ConvertToUpper
    {
        public void NameToUpper()
        {
            string takeInput = null;
            Console.WriteLine("Please type your name and press enter : ");
            takeInput = Console.ReadLine();
            int trypass = 0;
            while(Int32.TryParse(takeInput, out trypass))
            {
                Console.WriteLine("Please Type String Value");
                takeInput = Console.ReadLine() ;
            }
            string myNameUpperCase = null;
            if(!string.IsNullOrWhiteSpace(takeInput))
            {
                myNameUpperCase = takeInput.ToUpper();
                Console.WriteLine($"You converted name to upper {myNameUpperCase}");
            }
            else
            {
                Console.WriteLine("You have added an empty value");
            }
        }
        

    }
}
