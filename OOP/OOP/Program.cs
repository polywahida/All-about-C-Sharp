namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car bmw = new Car(Color.Red, "bmw-fly", "bm-1", DateTime.Now.AddYears(-10), 145);
            Car audi = new Car(Color.Black, "Audi-gls", "au-1", DateTime.Now.AddYears(-5), 118);
            Car mercedez = new Car();


            bmw.Start();
            audi.Start();
            bmw.Speed();
            audi.Speed();
            bmw.CarDetails();
            audi.CarDetails();
            //Console.WriteLine(bmw);
            //bmw.color();
            //bmw.Start();
            //bmw.color = Color.Red;
            //Console.WriteLine(bmw.color);

            //Console.WriteLine(bmw);
            //bmw.Speed();

            //Car audi = new Car();
            //audi.Start();
            //audi.Speed();
        }
    }
}