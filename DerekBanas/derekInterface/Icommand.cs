using System;
using System.Collections.Generic;
using System.Text;

namespace DerekBanas.derekInterface
{
    interface Icommand
    {
        void Execute();
        void Undo();
    }
}
