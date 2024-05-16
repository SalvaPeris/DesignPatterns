using Mediator.Interfaces;
using Mediator;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is the Mediator pattern demo: \n");

        IFacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();
        
        User Ram = new ConcreteUser("Ram");
        User Dave = new ConcreteUser("Dave");
        User Smith = new ConcreteUser("Smith");
        User Rajesh = new ConcreteUser("Rajesh");
        User Sam = new ConcreteUser("Sam");
        User Pam = new ConcreteUser("Pam");
        User Anurag = new ConcreteUser("Anurag");
        User John = new ConcreteUser("John");

        facebookMediator.RegisterUser(Ram);
        facebookMediator.RegisterUser(Dave);
        facebookMediator.RegisterUser(Smith);
        facebookMediator.RegisterUser(Rajesh);
        facebookMediator.RegisterUser(Sam);
        facebookMediator.RegisterUser(Pam);
        facebookMediator.RegisterUser(Anurag);
        facebookMediator.RegisterUser(John);

        Dave.Send("It is very good to learn Design Patterns");
        Console.WriteLine();

        Rajesh.Send("What is Design Patterns?");
        Console.Read();
    }
}