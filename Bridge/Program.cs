using Bridge.Models;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is the bridge pattern demo:");

        AbstractRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTV());
        sonyRemoteControl.SwitchOn();
        sonyRemoteControl.SetChannel(1);
        sonyRemoteControl.SwitchOff();

        AbstractRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
        samsungRemoteControl.SwitchOn();
        samsungRemoteControl.SetChannel(2);
        samsungRemoteControl.SwitchOff();

        Console.ReadKey();
    }
}