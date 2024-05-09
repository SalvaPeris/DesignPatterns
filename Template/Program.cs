using Template;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is the template pattern demo:");
        Console.WriteLine("\n \n");

        Console.WriteLine("Building a Concrete house: ");
        HouseTemplate houseTemplate = new ConcreteHouse();
        houseTemplate.BuildHouse();
        Console.WriteLine("\n");

        Console.WriteLine("Build a Wooden House:");
        houseTemplate = new WoodenHouse();
        houseTemplate.BuildHouse();
        Console.Read();
    }
}