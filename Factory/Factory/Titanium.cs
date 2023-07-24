namespace Factory.Factory
{
    public class Titanium : CreditCard
    {
        public override string GetCardType()
        {
            return "Titanium";
        }

        public override int GetCreditLimit()
        {
            return 35000;
        }
    }
}
