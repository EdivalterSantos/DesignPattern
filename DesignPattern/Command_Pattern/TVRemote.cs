
namespace Command_Pattern
{
    class TVRemote
    {
        public static ElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
