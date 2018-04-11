
namespace Command_Pattern
{
    class TurnVolumeUp
    {
        private readonly ElectronicDevice _theDevice;

        public TurnVolumeUp(ElectronicDevice newDevice)
        {
            _theDevice = newDevice;
        }

        public void Execute()
        {
            _theDevice.VolumeUp();
        }

    }
}
