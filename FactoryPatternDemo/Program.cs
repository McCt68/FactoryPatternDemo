namespace FactoryPatternDemo
{
    // Client
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Betaling:\n");
           
            // Brug factory til at oprette instans af KreditKortBetaling
            IBetaling betaling = BetalingFactory.OpretBetaling(BetalingsMetode.KreditKortBetaling);

            // Brug metoden Betal fra KreditKortBetaling klassen
            betaling.Betal(500);
        }
    }
}
