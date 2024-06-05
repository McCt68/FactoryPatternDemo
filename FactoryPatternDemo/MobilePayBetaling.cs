namespace FactoryPatternDemo
{
    public class MobilePayBetaling : IBetaling
    {
        public void Betal(decimal beløb)
        {
            Console.WriteLine($"Betalt {beløb} med Mobile Pay");
        }
    }
}
