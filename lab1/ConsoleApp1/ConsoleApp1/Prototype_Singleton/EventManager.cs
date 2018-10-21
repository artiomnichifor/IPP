using ConsoleApp1.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Prototype
{
    class CommonEventManager
    {
        private static CommonEventManager instance = null;

        List<CommonEvent> events = new List<CommonEvent>();

        private CommonEventManager()
        {
            Console.WriteLine("Singleton created");
        }

        public static CommonEventManager Instance
        {
            get
            {
                if (instance == null)
                {
                    
                    if (instance == null)
                    {
                        instance = new CommonEventManager();
                    }
                    
                }
                return instance;
            }
        }


        public void AddEvent(CommonEvent _event)
        {
            events.Add(_event);
        }

        public void RemoveEvent(CommonEvent _event)
        {
            events.Remove(_event);
        }

        public CommonEvent GetEvent(string eventName)
        {
            return events.SingleOrDefault(e => e.EventName == eventName);
        }

        public void AddAttendant(string eventName, Employee employee)
        {
            var _event = GetEvent(eventName);
            _event.AddEmployee(employee);
        }

        public void RemoveAttendant(string eventName, Employee employee)
        {
            var _event = GetEvent(eventName);
            _event.RemoveEmployee(employee);
        }

    }
}
