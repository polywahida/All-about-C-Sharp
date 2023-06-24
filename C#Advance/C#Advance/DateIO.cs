using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advance
{
    internal class DateIO
    {
        public static void CheckDateClass()
        {
            //DateTime dateTime = new DateTime(2018, 5, 31);

            //DateTime now = DateTime.Now;
            //DateTime tomorrow = GetTomorrow();  

            //Console.WriteLine(now.Year);
            // Console.WriteLine(tomorrow);

            Console.WriteLine("Write your bdate like this format yyyy-mm-dd");
            var userInput = Console.ReadLine() ?? "1991-11-01";
            var lifeSpan = GetTotalBirthdayCount(userInput);

            if (lifeSpan > 0)
            {
                Console.WriteLine($"You have lived {lifeSpan} days");
            }
            else
            {
                Console.WriteLine("Please enter the correct format");
            }
        }

        public static DateTime GetTomorrow()
        {
            //return DateTime.Now.AddDays(1);
            return DateTime.Now.AddYears(1);
        }

        public static int GetTotalBirthdayCount(string input)
        {
            DateTime now = DateTime.Now;

            DateTime datetime;
            if (DateTime.TryParse(input, out datetime))
            {

                Console.WriteLine(datetime);
                TimeSpan days = now.Subtract(datetime);
                return days.Days;

            }
            else
            {
                return 0;
            }

        }




    }
}