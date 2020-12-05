using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanas.derekInterface
{
    class PowerButton : Icommand
    {
        IElectronicDevice device;

        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off(); 
        }
    }
}
