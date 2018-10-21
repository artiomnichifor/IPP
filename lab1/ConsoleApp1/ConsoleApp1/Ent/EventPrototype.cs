using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Prototype
{
    public abstract class EventPrototype
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string Subject { get; set; }

        public abstract EventPrototype Clone(); 
    }
}
