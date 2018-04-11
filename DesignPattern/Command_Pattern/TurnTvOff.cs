
namespace Command_Pattern
{
    class TurnTvOff
    {
        private ElectronicDevice _theDevice;

        public TurnTvOff(ElectronicDevice newDevice)
        {
            _theDevice = newDevice;
        }


        public void Execute()
        {
            _theDevice.DeviceOff();
        }

    }
}
