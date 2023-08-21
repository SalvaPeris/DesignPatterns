namespace Bridge.Models
{
    public class SonyLedTV: ILedTV
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"Setting channel {channelNumber} on Sony TV");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Sony TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Sony TV");
        }
    }
}
