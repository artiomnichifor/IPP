using BehavioralPatterns.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Group groupA = new HighPriorityGroup("A", "HPG");
            Group groupB = new ModeratePriorityGroup("B", "MPG");
            Group groupC = new LowPriorityGroup("C", "LPG");

            //ChainOfResponsibilities
            groupA.SetSuccessor(groupB);
            groupB.SetSuccessor(groupC);

            Requestor requestor = new Requestor();
            requestor.Name = "req1";
            requestor.Priority = 111;
            requestor.TypeOfFlight = "internal";

            Console.WriteLine("Assign customer to a group");
            groupA.HandleRequest(requestor);
            Console.WriteLine($"Customer was assigned to group {requestor.Group.Name}");
            //Console.Write(groupC.requestors.First().Name);
            //Console.Write(requestor.Group.Name);
            Console.ReadKey();


            //State
            Console.WriteLine("First call");
            requestor.Call();
            Console.ReadKey();
            Console.WriteLine("Second call");
            requestor.Call();
            Console.ReadKey();
            Console.WriteLine("Third call");
            requestor.Call();
            Console.ReadKey();
            Console.WriteLine("Customer support call");
            requestor.Call();
            Console.ReadKey();




            Console.ReadKey();
        }
    }
}
