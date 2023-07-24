using Factory;
using Factory.Factory;
using Factory.NoFactory;

internal class Program
{
    private static void Main(string[] args)
    {
        #region NoFactory
        string cardTypeNoFactory = "MoneyBack";

        ICreditCard? cardDetailsNoFactory = null;

        if (cardTypeNoFactory == "MoneyBack")
        {
            cardDetailsNoFactory = new MoneyBackNoFactory();
        }
        else if (cardTypeNoFactory == "Titanium")
        {
            cardDetailsNoFactory = new TitaniumNoFactory();
        }
        else if (cardTypeNoFactory == "Platinum")
        {
            cardDetailsNoFactory = new PlatinumNoFactory();
        }

        if (cardDetailsNoFactory != null)
        {
            Console.WriteLine("NO FACTORY METHOD");
            Console.WriteLine("CardType : " + cardDetailsNoFactory.GetCardType());
            Console.WriteLine("CreditLimit : " + cardDetailsNoFactory.GetCreditLimit());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }

        #endregion

        #region Factory
        string cardType = "MoneyBack";

        CreditCard cardDetails = CreditCardFactory.GetCreditCard(cardType);
        if (cardDetails != null)
        {
            Console.WriteLine("FACTORY METHOD");
            Console.WriteLine("CardType : " + cardDetails.GetCardType());
            Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
        }
        else
            Console.Write("Invalid Card Type");

        Console.ReadLine();
        #endregion
    }
}