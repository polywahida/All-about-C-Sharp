using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQA
{
    internal class TestLINQA
    {
        public static void TestOddNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("odd numbers");
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            var oddNumbers1 = numbers.Where(x => x % 2 != 0);
            //.Select(x => new {Name = "Odd", value = x});
            Console.WriteLine(oddNumbers);
            foreach (var item in oddNumbers)
            {
                Console.WriteLine("Odd number " + item);
            }
        }
        public static void OrderBySortedInt()
        {
            int[] numbers = { 15, 20, 30, 4, 69, 75, 5 };
            
            IEnumerable<int> sortedInt = from i in numbers orderby i select i;
            //IEnumerable<int> reversINT = sortedInt.Reverse();
            var shortedInt = numbers.OrderBy(x => x).ToList();
            foreach (var item in shortedInt)
            {
                Console.WriteLine(item);
                Console.Write("  ");
            }
        }
    }    
}