using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builder
{
    class MorningShiftBuilder : ShiftBuilder
    {
        public override void SetBreakTime()
        {

            shift.BreakTime = TimeSpan.FromHours(13);
        }

        public override void SetName()
        {
            shift.ShiftName = "MorningShift";
        }

        public override void SetSfiftTimmings()
        {
            shift.StartTime = TimeSpan.FromHours(8);
            shift.EndTime = TimeSpan.FromHours(17);
        }
    }
}
