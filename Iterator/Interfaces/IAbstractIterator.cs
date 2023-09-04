using Iterator.Models;

namespace Iterator.Interfaces
{
    public interface IAbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}
