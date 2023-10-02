namespace ChainOfResponsibility
{
    public class ATM
    {
        private readonly TwoThousandHandler twoThousandHandler = new();
        private readonly FiveHundredHandler fiveHundredHandler = new();
        private readonly HundredHandler hundredHandler = new();

        public ATM()
        {
            twoThousandHandler.SetNextHandler(fiveHundredHandler);
            fiveHundredHandler.SetNextHandler(hundredHandler);
        }

        public void Withdraw(long requestAmount)
        {
            if (requestAmount % 100 == 0)
                twoThousandHandler.DispatchNote(requestAmount);
            else
                Console.WriteLine($"Amount must be a multiple of 100 and you entered {requestAmount}");
        }
    }
}
