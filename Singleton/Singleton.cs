namespace Singleton
{
    //This class is sealed because I want only one instance
    //Basically, seal the class, create a private constructor, and public static method to return the class.
    public sealed class Singleton
    {
        //This variable value will be increment by 1 each time the object of the class is created
        private static int Counter = 0;

        //This variable is going to store the Singleton Instance
        private static Singleton Instance = null;

        public static Singleton GetInstance()
        {
            //If the variable instance is null, then create the Singleton instance 
            //else return the already created singleton instance
            //This version is not thread safe
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            //Return the Singleton Instance
            return Instance;
        }

        private Singleton()
        {
            Counter++;
            Console.WriteLine($"Counter: {Counter.ToString()}");
        }

        public void PrinDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
