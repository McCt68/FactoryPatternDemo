namespace FactoryPatternDemo
{
    public class KreditKortBetaling : IBetaling
    {
        public void Betal(decimal beløb)
        {
            Console.WriteLine($"Betalt {beløb} med KreditKort");
        }
    }
}
