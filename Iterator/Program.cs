using Iterator;
using Iterator.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is a iterator pattern demo:");

        ConcreteCollection collection = new();
        collection.AddEmployee(new Employee("Salva", 100));
        collection.AddEmployee(new Employee("Juan", 200));
        collection.AddEmployee(new Employee("Pepe", 300));

        IteratorObj iterator = collection.CreateIterator();
        Console.WriteLine("Iterating over collection:");

        for(Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
        {
            Console.WriteLine($"Id: {emp.Id} - Name: {emp.Name}");
        }
        Console.Read();
    }
}