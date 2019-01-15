using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralPatterns.Entitites;

namespace BehavioralPatterns.St
{
    class ServedState : IState
    {
        public void Proceed(Requestor req)
        {
            Console.WriteLine($"{req.Group.employees.Find(x => x.Position == "FlightBuilder").Name} buys flight tickets");
            Console.WriteLine($"{req.Group.employees.Find(x => x.Position == "Receiver").Name} calling back customer {req.Name}");
            Console.WriteLine("Summing up");
            req.State = new ServiceState();

        }
    }
}
