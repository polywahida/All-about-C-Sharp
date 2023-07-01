namespace DelegateMulticast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var smartTv = new SmartTv("Sony-Tv");
            var washingMachine = new WashingMachine("Walton-WashingMachin");
            var oven = new Oven("Siemens-oven");

           // smartTv.StartMachine();
           // washingMachine.StartMachine();
           // oven.StartMachine();

            startAllMachine();
            Console.Read();
            stopAllMachine();

            //smartTv.StopMachine();
            //washingMachine.StopMachine();   
            //oven.StopMachine();
        }
        public static void startAllMachine()
        {
            MachineManager.TriggerOnStart();

        }

        public static void stopAllMachine() 
        { 
          MachineManager?.TriggerOnStop();
             
        }



    }
}