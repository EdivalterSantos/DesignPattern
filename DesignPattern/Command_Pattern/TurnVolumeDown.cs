
namespace Command_Pattern
{
    class TurnVolumeDown
    {
        private ElectronicDevice _theDevice;

        public TurnVolumeDown(ElectronicDevice newDevice)
        {
            _theDevice = newDevice;
        }

        public void Execute()
        {
            _theDevice.VolumeDown();
        }

    }
}
