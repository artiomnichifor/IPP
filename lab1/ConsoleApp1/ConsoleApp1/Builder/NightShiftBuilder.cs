using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builder
{
    class NightShiftBuilder : ShiftBuilder
    {
        public override void SetBreakTime()
        {

            shift.BreakTime = TimeSpan.FromHours(17);
        }

        public override void SetName()
        {
            shift.ShiftName = "NightShift";
        }

        public override void SetSfiftTimmings()
        {
            shift.StartTime = TimeSpan.FromHours(13);
            shift.EndTime = TimeSpan.FromHours(22);
        }
    }
}
