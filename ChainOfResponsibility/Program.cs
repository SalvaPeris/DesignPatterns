using ChainOfResponsibility;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is an ATM demo for explain how works chain of responsibility pattern:");

        ATM atm = new();
        Console.WriteLine("Requested amount 5000");
        atm.Withdraw(5000);

        Console.WriteLine("\n");

        Console.WriteLine("Requested Amount 600");
        atm.Withdraw(600);

        Console.Read();
    }
}