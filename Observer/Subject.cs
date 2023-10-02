using ObserverDesignPattern.Interfaces;

namespace ObserverDesignPattern
{
    public class Subject : ISubject
    {
        private List<IObserver> Observers = new List<IObserver>();
        private string? ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }

        public Subject(string? productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string? GetAvailability()
        {
            return Availability is not null? Availability : null;
        }

        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Product Name :"
                            + ProductName + ", product Price : "
                            + ProductPrice + " is Now available. So, notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserver observer in Observers)
            {
                observer.Update(Availability);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((Observer)observer).UserName);
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Observer Removed : " + ((Observer)observer).UserName);
            Observers.Remove(observer);
        }
    }
}
