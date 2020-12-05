using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanas.derekInterface
{
    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }
        void Move();
        void Stop();
    }
}
