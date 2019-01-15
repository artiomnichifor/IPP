using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralPatterns.Entitites;

namespace BehavioralPatterns.St
{
    class PendingState : IState
    {
        public void Proceed(Requestor req)
        {
            Console.WriteLine($"Custemer {req.Name} making a call to {req.Group.employees.Find(x => x.Position == "Receiver").Name}");
            Console.WriteLine("Request...");
            Console.WriteLine("Ending the call.Waiting...");
            req.State = new InquiringState();
        }

    }
}
