namespace AdvanceOOP_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IAnimal[] animals =
            {
                new DOg(),
                new Cat(),
                new Bird(),

            };
            foreach (IAnimal animal in animals)
            {
                animal.MakeSound();
                animal.Move();
            }
          
        }
    }
}