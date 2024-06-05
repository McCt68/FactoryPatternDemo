namespace FactoryPatternDemo
{
    public class BetalingFactory
    {
        public static IBetaling OpretBetaling(BetalingsMetode betalingsMetode)
        {
            // kik på værdien af enum BetalingsMetode
            switch (betalingsMetode)
            {
                case BetalingsMetode.KreditKortBetaling:
                    return new KreditKortBetaling();

                case BetalingsMetode.MobilePayBetaling:
                    return new MobilePayBetaling();

                case BetalingsMetode.BankOverførselBetaling:
                    return new BankOverførselBetaling();

                default:
                    throw new NotSupportedException(@"{betalingsMetode}Betalings metode ugyldig.");
            }
        }
    }
}
