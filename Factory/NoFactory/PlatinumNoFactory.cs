namespace Factory.NoFactory
{
    public class PlatinumNoFactory : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }
}
