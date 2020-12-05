using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanas.derekInterface
{
    class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
