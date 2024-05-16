﻿using Mediator.Interfaces;

namespace Mediator
{
    public abstract class User
    {
        protected string Name;
        public IFacebookGroupMediator Mediator { get; set; }

        public User(string name)
        {
            this.Name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
