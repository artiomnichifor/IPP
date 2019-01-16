using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Entitites
{
    class Shift
    {
        public string ShiftName { get; }
        public string StartTime { get; }
        public string EndTime { get; }

        public Shift(string shiftName, string startTime, string endTime)
        {
            this.ShiftName = shiftName;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public string ShowShiftData()
        {
            return $"On {ShiftName} shift, starting on {StartTime}, ending on {EndTime}";
        }
    }
}
