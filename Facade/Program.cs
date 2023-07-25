using Facade;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is a project that uses a Facade class");
        Order order = new Order();
        order.PlaceOrder();
        Console.Read();
    }
}