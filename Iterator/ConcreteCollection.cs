using Iterator.Interfaces;
using Iterator.Models;

namespace Iterator
{
    public class ConcreteCollection : IAbstractCollection
    {
        private List<Employee> listEmployees = new List<Employee>();

        public IteratorObj CreateIterator()
        {
            return new IteratorObj(this);
        }

        public int Count
        {
            get { return listEmployees.Count; }
        }

        public void AddEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }

        public Employee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}
