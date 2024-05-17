namespace Memento
{
    public class Caretaker
    {
        private List<Memento> LedTvList = [];
        
        public void AddMemento(Memento m)
        {
            LedTvList.Add(m);
            Console.WriteLine("Led TV's snapshots Maintained by CareTaker :" + m.GetDetails());
        }
        
        public Memento GetMemento(int index)
        {
            return LedTvList[index];
        }
    }
}
