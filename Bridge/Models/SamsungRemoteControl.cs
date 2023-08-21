namespace Bridge.Models
{
    public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(ILedTV ledTV)
        {
            this.ledTV = ledTV;
        }

        public override void SetChannel(int channelNumber)
        {
            ledTV?.SetChannel(channelNumber);
        }

        public override void SwitchOff()
        {
            ledTV?.SwitchOff();
        }

        public override void SwitchOn()
        {
            ledTV?.SwitchOn();
        }
    }
}
