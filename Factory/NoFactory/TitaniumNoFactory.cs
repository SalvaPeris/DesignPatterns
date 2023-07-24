namespace Factory.NoFactory
{
    public class TitaniumNoFactory : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
