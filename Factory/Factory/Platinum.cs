namespace Factory.Factory
{
    public class Platinum : CreditCard
    {
        public override string GetCardType()
        {
            return "Platinum";
        }

        public override int GetCreditLimit()
        {
            return 25000;
        }
    }
}
