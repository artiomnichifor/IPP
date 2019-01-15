using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralPatterns.Entitites;

namespace BehavioralPatterns.St
{
    class InquiringState : IState
    {
        public void Proceed(Requestor req)
        {
            Console.WriteLine($"{req.Group.employees.Find(x => x.Position == "FlightBuilder").Name} elaboratting flight route...");
            Console.WriteLine($"{req.Group.employees.Find(x => x.Position == "Receiver").Name} calling back customer {req.Name}");
            Console.WriteLine("Analizing the offers.Choosing...");
            req.State = new ServedState();
        }
    }
}
