namespace Factory.Factory
{
    /*
     * 
     * DIFFERENCE BETWEEN ABSTRACT AND VIRTUAL
     * 
     * Virtual methods have an implementation and provide the derived classes with the option of overriding it. 
     * Abstract methods do not provide an implementation and force the derived classes to override the method.
     * 
     * 
     */

    public abstract class CreditCard
    {
        public abstract string GetCardType();
        public abstract int GetCreditLimit();
    }
}
