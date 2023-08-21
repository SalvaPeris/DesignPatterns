namespace Composite.Models
{
    public class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Leaf(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public void DisplayPrice()
        {
            Console.WriteLine($"Component name: {Name} and price: {Price}");
        }
    }
}
