using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builder
{
    class ShiftAllocator
    {
        public void Allocate(ShiftBuilder shiftBuilder)
        {
            shiftBuilder.SetName();
            shiftBuilder.SetSfiftTimmings();
            shiftBuilder.SetBreakTime();
        }
    }
}
