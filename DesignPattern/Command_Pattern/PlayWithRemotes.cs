
namespace Command_Pattern
{
    class PlayWithRemotes
    {
        static void Main(string[] args)
        {
            ElectronicDevice device = TVRemote.GetDevice();
            TurnTvOn onCommand = new TurnTvOn(device);
            DeviceButton onPressed = new DeviceButton(onCommand);
            onPressed.Press();

            //------------------------------------------------------

            TurnTvOff offCommand = new TurnTvOff(device);
            onPressed = new DeviceButton(offCommand);
            onPressed.Press();
        }
    }
}
