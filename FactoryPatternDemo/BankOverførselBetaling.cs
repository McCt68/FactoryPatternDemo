namespace FactoryPatternDemo
{
    public class BankOverførselBetaling : IBetaling
    {
        public void Betal(decimal beløb)
        {
            Console.WriteLine($"Betalt {beløb} via bank overførsel");
        }
    }
}
