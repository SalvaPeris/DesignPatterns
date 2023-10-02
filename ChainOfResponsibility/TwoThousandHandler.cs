namespace ChainOfResponsibility
{
    public class TwoThousandHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberNotesToBeDispatched = requestedAmount / 2000;

            if(numberNotesToBeDispatched > 0)
            {
                if(numberNotesToBeDispatched > 1)
                    Console.WriteLine(numberNotesToBeDispatched + " Two Thousand notes are dispatched by TwoThousandHandler");
                else
                    Console.WriteLine(numberNotesToBeDispatched + " Two Thousand note is dispatched by TwoThousandHandler");
            }

            long pendingAmountToBeProcessed = requestedAmount % 2000;

            if(pendingAmountToBeProcessed > 0)
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
        }
    }
}
