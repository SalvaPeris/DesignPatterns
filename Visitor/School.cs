using Visitor.Interfaces;

namespace Visitor
{
    public class School
    {
        private static readonly List<IElement> Elements = new List<IElement>();
        static School()
        {
            Elements = new List<IElement>
            {
                new Kid("Ram"),
                new Kid("Sara"),
                new Kid("Pam")
            };
        }
        
        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in Elements)
                kid.Accept(visitor);
        }
    }
}
