namespace Bridge.Models
{
    public class SonyRemoteControl : AbstractRemoteControl
    {
        public SonyRemoteControl(ILedTV ledTV)
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
