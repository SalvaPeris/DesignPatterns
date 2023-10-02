namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler? NextHandler;

        public void SetNextHandler(Handler NextHandler) 
        {
            this.NextHandler = NextHandler;       
        }

        public abstract void DispatchNote(long requestedAmount);
    }
}
