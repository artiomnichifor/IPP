using ConsoleApp1.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builder
{
    abstract class ShiftBuilder
    {
        protected Shift shift = new Shift();

        public Shift Shift { get { return shift; } }

        public abstract void SetName();
        public abstract void SetSfiftTimmings();
        public abstract void SetBreakTime();

    }
}
