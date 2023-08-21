namespace Bridge.Models
{
    public abstract class AbstractRemoteControl
    {
        protected ILedTV? ledTV;
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);

    }
}
