namespace Memento
{
    public class Memento
    {
        public LedTV LedTV { get; set; }
        
        public Memento(LedTV ledTV)
        {
            LedTV = ledTV;
        }

        public string GetDetails()
        {
            return "Memento [Led TV= " + LedTV.GetDetails() + "]";
        }
    }
}
