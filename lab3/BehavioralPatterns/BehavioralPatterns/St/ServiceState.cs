using BehavioralPatterns.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.St
{
    class ServiceState : IState
    {
        public void Proceed(Requestor req)
        {
            Console.WriteLine($"{req.Name} calls customers support {req.Group.employees.Find(x => x.Position == "Support").Name}");
            Console.WriteLine("Relating the problems...Inquiring...");
        }
    }
}
