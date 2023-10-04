using State.Interfaces;

namespace State
{
    public class AutomaticTellerMachine : IATMState
    {
        public IATMState ATMachineState = new DebitCardNotInsertedState();

        public AutomaticTellerMachine() { }

        public void EjectDebitCard()
        {
            ATMachineState.EjectDebitCard();

            if (ATMachineState is DebitCardInsertedState)
            {
                // Debit Card has been ejected so the internal state of the ATM Machine
                // has been changed to 'DebitCardNotInsertedState'
                ATMachineState = new DebitCardNotInsertedState();
                Console.WriteLine($"ATM Machine internal state has been Changed to : {ATMachineState.GetType().Name}");
            }
        }

        public void EnterPin()
        {
            ATMachineState.EnterPin();
        }

        public void InsertDebitCard()
        {
            ATMachineState.InsertDebitCard();

            if(ATMachineState is DebitCardNotInsertedState)
            {
                ATMachineState = new DebitCardInsertedState();
                Console.WriteLine($"ATM Machine internal state has been changed to : {ATMachineState.GetType().Name}");
            }

        }

        public void WithdrawMoney()
        {
            ATMachineState.WithdrawMoney();
        }
    }
}
