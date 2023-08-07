using Prototype.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is the NO prototype pattern demo.");

        Employee employee1 = new Employee() { Name = "Juan", Department = "Informática" };
        Employee employee2 = employee1;

        employee2.Name = "Salva";

        Console.WriteLine("Employee1: ");
        Console.WriteLine($"Name: {employee1.Name}, Dept.: {employee1.Department}" );
        Console.WriteLine("Employee2: ");
        Console.WriteLine($"Name: {employee2.Name}, Dept.: {employee2.Department}" );


        Console.WriteLine("This is the prototype pattern demo.");

        Employee employee3 = new Employee() { Name = "Juan", Department = "Informática" };
        Employee employee4 = employee3.GetClone();

        employee4.Name = "Salva";

        Console.WriteLine("Employee3: ");
        Console.WriteLine($"Name: {employee3.Name}, Dept.: {employee3.Department}");
        Console.WriteLine("Employee4: ");
        Console.WriteLine($"Name: {employee4.Name}, Dept.: {employee4.Department}");


        Console.ReadKey();

    }
}