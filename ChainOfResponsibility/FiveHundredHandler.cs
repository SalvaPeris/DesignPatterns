namespace ChainOfResponsibility
{
    public class FiveHundredHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberNotesToBeDispatched = requestedAmount / 500;

            if (numberNotesToBeDispatched > 0)
            {
                if (numberNotesToBeDispatched > 1)
                    Console.WriteLine(numberNotesToBeDispatched + " Five Hundred note are dispatched by FiveHundredHandler");
                else
                    Console.WriteLine(numberNotesToBeDispatched + " Five Hundred note is dispatched by FiveHundredHandler");
            }

            long pendingAmountToBeProcessed = requestedAmount % 500;

            if (pendingAmountToBeProcessed > 0)
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
        }
    }
}
