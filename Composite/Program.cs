using Composite.Models;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is the composite pattern demo:");

        //Creating Leaf Objects or you can say child objects
        IComponent hardDisk = new Leaf("Hard Disk", 2000);
        IComponent ram = new Leaf("RAM", 3000);
        IComponent cpu = new Leaf("CPU", 2000);
        IComponent mouse = new Leaf("Mouse", 2000);
        IComponent keyboard = new Leaf("Keyboard", 2000);

        //Creating Composite Objects
        CompositeObject motherBoard = new("MotherBoard");
        CompositeObject cabinet = new("Cabinet");
        CompositeObject peripherals = new("Peripherals");
        CompositeObject computer = new("Computer");

        motherBoard.AddComponent(cpu);
        motherBoard.AddComponent(ram);

        cabinet.AddComponent(motherBoard);
        cabinet.AddComponent(hardDisk);

        peripherals.AddComponent(mouse);
        peripherals.AddComponent(keyboard);

        computer.AddComponent(cabinet);
        computer.AddComponent(peripherals);

        Console.WriteLine("Price of Computer Composite Components");
        computer.DisplayPrice();

        Console.WriteLine("\nPrice of Leaf Component (mouse):");
        mouse.DisplayPrice();

        Console.ReadKey();
    }
}