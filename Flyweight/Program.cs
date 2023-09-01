using Flyweight;
using Flyweight.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is Flyweight pattern demo:");

        Console.WriteLine("\n Red color circles ");
        for (int i = 0; i < 3; i++)
        {
            Circle? circle = (Circle?)ShapeFactory.GetShape("circle");
            circle?.SetColor("red");
            circle?.Draw();
        }

        Console.WriteLine("\n Green color circles ");
        for (int i = 0; i < 3; i++)
        {
            Circle? circle = (Circle?)ShapeFactory.GetShape("circle");
            circle?.SetColor("green");
            circle?.Draw();
        }

        Console.WriteLine("\n Black color circles ");
        for (int i = 0; i < 3; i++)
        {
            Circle? circle = (Circle?)ShapeFactory.GetShape("circle");
            circle?.SetColor("black");
            circle?.Draw();
        }

        Console.ReadKey();
    }
}