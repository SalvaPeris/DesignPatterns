using Decorator.Interfaces;

namespace Decorator.Models
{
    public class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car) { }

        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return base.ManufactureCar();
        }

        public void AddEngine(ICar car)
        {
            if (car is BMWCar BMWCar)
            {
                BMWCar.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
            }
        }
    }
}
