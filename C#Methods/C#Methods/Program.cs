namespace C_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding Numbers");
            //var result = AddNumber (2,4);
            //console.WriteLine(result);
            var sum = new MethodWithoutArgue();
            var result1 = sum.AddNumberWithoutParam();
            Console.WriteLine(result1);
            var result2 = sum.AddNumberWithConst();
            Console.WriteLine(result2);
            var convert = new ConvertToUpper();
            convert.NameToUpper();
        }
        static int AddNumber(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}