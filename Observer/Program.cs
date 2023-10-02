
using ObserverDesignPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is observer pattern demo:");

        Subject iPhone = new Subject("iPhone", 800, "Out of stock");

        Observer user1 = new("Manolo");
        user1.AddSubscriber(iPhone);

        Observer user2 = new("Pepe");
        user2.AddSubscriber(iPhone);

        Observer user3 = new("Juan");
        user3.AddSubscriber(iPhone);
        
        Console.WriteLine($"iPhone current state is {iPhone.GetAvailability()}");
        
        user3.RemoveSubscriber(iPhone);

        iPhone.SetAvailability("Available");

        Console.Read();
    }
}