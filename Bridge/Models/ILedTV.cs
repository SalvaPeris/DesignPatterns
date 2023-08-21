namespace Bridge.Models
{
    public interface ILedTV
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channelNumber);
    }
}
