namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Call the GetInstance static method to get the Singleton Instance
            Singleton fromMe = Singleton.GetInstance();
            fromMe.PrinDetails("Hello from me");
            
            Singleton fromMyNeighbour = Singleton.GetInstance();
            fromMyNeighbour.PrinDetails("Hello from my neighbour");
        }
    }
}