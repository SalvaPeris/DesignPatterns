using Mediator.Interfaces;

namespace Mediator
{

    public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        private List<User> UsersList = new List<User>();
        public void RegisterUser(User user)
        {
            UsersList.Add(user);
            user.Mediator = this;
        }

        public void SendMessage(string message, User user)
        {
            foreach (User u in UsersList)
                if (u != user)
                    u.Receive(message);
        }
    }
}
