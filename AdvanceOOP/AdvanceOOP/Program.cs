using System.Collections;

namespace AdvanceOOP
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //collection
            //Hash Dict
            Hashtable ht = new Hashtable();
            //Permission 
            //createAccess //CreateaccessOnbehalf
            var database = dbcontext.Permission().where(UserId == id);

            Dictionary<string, bool> dict = new Dictionary<string, bool>
            {
                new Dictionary<string, bool>("database.createAccess",true),
                new Dictionary<string, bool>("database.CreateAccess",true),

            }
            Duck duck1 = new Duck("Donald", "Red", "Seeds");
            Duck duck2 = new Duck("Harry", "Black", "SeedsAll");
            duck1.Eat();
            duck2.Eat();
            duck1.Fly();
            duck2.Fly();
            

        }
    }
} 