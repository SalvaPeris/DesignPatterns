using Iterator.Interfaces;
using Iterator.Models;

namespace Iterator
{
    public class IteratorObj : IAbstractIterator
    {
        private ConcreteCollection Collection;
        
        private int Current = 0;

        private readonly int Step = 1;

        public IteratorObj(ConcreteCollection concreteCollection) 
        { 
            this.Collection = concreteCollection;
        }

        public Employee First()
        {
            Current = 0;
            return Collection.GetEmployee(Current);
        }

        public Employee Next()
        {
            Current += Step;
            if (!IsCompleted)
            {
                return Collection.GetEmployee(Current);
            }
            else
            {
                return null;
            }
        }

        public bool IsCompleted
        {
            get { return Current >= Collection.Count; }
        }

    }
}
