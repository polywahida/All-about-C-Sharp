namespace Sealed_HasARel._Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car()
            {
               new Audi (400,"Black","A4"),
               new BMW(500,"Red","M3")
            };
            foreach (var car in cars)
            {
                car.Repair();
                car.showDetails();
            }
            Audi audi = new Audi(450, "White", "M5");
            audi.showDetails();
            audi.SetCarInfo(450455, "Poly");


            M5 myM5 = new M5(260, "Blue", "M5 super car");
            myM5.Repair();

        }
    }    
}   