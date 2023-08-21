namespace Composite.Models
{
    public class CompositeObject : IComponent
    {
        public string Name { get; set; }
        List<IComponent> components = new List<IComponent>();

        public CompositeObject(string name)
        {
            this.Name = name;
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void DisplayPrice()
        {
            foreach (var component in components)
            {
                component.DisplayPrice();
            }
        }
    }
}
