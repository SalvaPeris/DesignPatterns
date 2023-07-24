namespace Factory.NoFactory
{
    public class MoneyBackNoFactory : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}