using Visitor;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is a Visitor pattern demo: \n");

        School school = new School();

        var visitor = new Doctor("Pepe");
        school.PerformOperation(visitor);
        Console.ReadLine();
    }
}