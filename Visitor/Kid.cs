using Visitor.Interfaces;

namespace Visitor
{
    public class Kid : IElement
    {
        public string Name { get; set; }

        public Kid(string name)
        {
            Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
