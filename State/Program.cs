using State;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is a state pattern design demo: ");

        AutomaticTellerMachine atMachine = new();

        Console.WriteLine($"ATM Current state : {atMachine.ATMachineState.GetType().Name}");
        Console.WriteLine();

        atMachine.EnterPin();
        atMachine.WithdrawMoney();
        atMachine.EjectDebitCard();
        atMachine.InsertDebitCard();

        Console.WriteLine();
        Console.WriteLine($"ATM Current state : {atMachine.ATMachineState.GetType().Name}");

        atMachine.EnterPin();
        atMachine.WithdrawMoney();
        atMachine.InsertDebitCard();
        atMachine.EjectDebitCard();

        Console.WriteLine();
        Console.WriteLine($"ATM Current state : {atMachine.ATMachineState.GetType().Name}");

        Console.Read();
    }
}