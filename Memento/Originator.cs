namespace Memento
{
    public class Originator
    {
        public LedTV? LedTV;
        
        public Memento CreateMemento()
        {
            return new Memento(LedTV);
        }

        public void SetMemento(Memento memento)
        {
            LedTV = memento.LedTV;
        }
        
        public string GetDetails()
        {
            return "Originator [Led TV=" + LedTV.GetDetails() + "]";
        }
    }
}
