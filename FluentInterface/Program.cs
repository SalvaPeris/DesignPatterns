using FluentInterface;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is a Fluent interface pattern demo");

        FluentEmployee fluentEmployee = new FluentEmployee();

        fluentEmployee.NameOfTheEmployee("Salva Peris")
            .Born("03/11/1900")
            .WorkingOn("Technology")
            .StaysAt("Spain");

        fluentEmployee.ShowDetails();
        Console.ReadKey();
    }
}