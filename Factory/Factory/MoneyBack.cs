namespace Factory.Factory
{
    public class MoneyBack : CreditCard
    {
        public override string GetCardType()
        {
            return "MoneyBack";
        }

        public override int GetCreditLimit()
        {
            return 15000;
        }
    }
}
