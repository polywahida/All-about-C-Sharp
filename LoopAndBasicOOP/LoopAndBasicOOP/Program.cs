//namespace LoopAndBasicOOP
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //palindrome 

//            //string[] wordCollection = {"level","hello","mom","dad","world" };
//            //foreach (var item in wordCollection)
//            //{
//            // bool isPalindrome = item.SequenceEqual(item.Reverse());
//            // Console.Writeline($"{item} is {(isPalindrome ? "a palindrome" : "not a palindrome")}");
//            //}
//            //Break and continue
//            //for (int counter = 0; counter < 10; counter++)
//            //{
//            //    Console.WriteLine(counter);
//            //    if (counter % 2 == 0)
//            //    {

//            //        Console.WriteLine("Next number is odd number");
//            //        continue;
//            //    }
//            //    Console.WriteLine(counter);
//            //}

//            ///while loop
//            //Integer reversal
//            int number = 123456;
//            int reversedNumber = 0;

//            while (number != 0)
//            {
//                int remainder = number % 10;
//                Console.WriteLine("Reminderr " + remainder);
//                reversedNumber = reversedNumber * 10 + remainder;

//                Console.WriteLine("reversedNumber" + reversedNumber);
//                number /= 10;//number = number / 10;

//            }

//            //do while 
//            //FizzBuzz
//            //15
//            //15/3 = 0; 15/5 = 0;
//            // 1- 100 = 3/3 = 0 = 5/5 =0

//            int num = 1;
//            do
//            {
//                if (num % 3 == 0 && num % 5 == 0)
//                {
//                    Console.WriteLine("FizzBuzz");
//                }
//                else if (num % 3 == 0)
//                {
//                    Console.WriteLine("Fizz");
//                }
//                else if (num % 5 == 0)
//                {
//                    Console.WriteLine("Buzz");
//                }
//                else
//                {
//                    Console.WriteLine(num);
//                }
//                num++;
//            } while (num <= 100);
            
            
//            //OOP
//            //class
//            //car-class
//            //object of car > Audi (),//Mercedez () //Opel (Water) // BMW

//            //Animal > Dog > cat > Rat>
//             //House-- Villa(),Hut

//            // Class is a blue print of an object.


//        }
//    }
//}