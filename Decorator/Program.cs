using Decorator.Interfaces;
using Decorator.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is a Decorator pattern demo");

        ICar bmwCar = new BMWCar();
        bmwCar.ManufactureCar();
        Console.WriteLine(bmwCar + "\n");

        ICar bmwCar2 = new BMWCar();
        PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
        carWithPetrolEngine.ManufactureCar();

        Console.ReadKey();
    }
}