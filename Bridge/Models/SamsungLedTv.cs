﻿namespace Bridge.Models
{
    public class SamsungLedTv : ILedTV
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"Setting channel {channelNumber} on Samsung TV");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Samsung TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Samsung TV");
        }
    }
}
