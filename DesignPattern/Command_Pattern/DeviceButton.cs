using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class DeviceButton
    {
        private Command _theCommand;

        public DeviceButton(Command newCommand)
        {
            _theCommand = newCommand;
        }

        public void Press()
        {
            _theCommand.Execute();
        }
    }
}
