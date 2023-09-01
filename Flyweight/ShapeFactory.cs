using Flyweight.Interfaces;
using Flyweight.Models;

namespace Flyweight
{
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> shapeMap = new();

        public static IShape? GetShape(string shapeName)
        {
            IShape? shape = null;

            if(shapeName.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                if(shapeMap.TryGetValue("circle", out shape))
                {
                }
                else
                {
                    shape = new Circle();
                    shapeMap.Add("circle", shape);
                    Console.WriteLine("Creating circle object with out any color in shapefactory \n");
                }
            }

            return shape;
        }
    }
}
