using BehavioralPatterns.Entitites;
using BehavioralPatterns.Observer;
using BehavioralPatterns.Strategy;
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

            //Command
            Employee empl1 = groupC.employees.Find(x => x.Position == "FlightBuilder");

            Flight flight1 = new Flight();
            flight1.Start = "S1";
            flight1.Destination = "D1";
            flight1.Price = 10;
            Flight flight2 = new Flight();
            flight2.Start = "S2";
            flight2.Destination = "D2";
            flight2.Price = 20;
            Flight flight3 = new Flight();
            flight3.Start = "S3";
            flight3.Destination = "D3";
            flight3.Price = 30;
            Flight flight4 = new Flight();
            flight4.Start = "S4";
            flight4.Destination = "D4";
            flight4.Price = 40;


            empl1.AddFlight(requestor, flight1);
            empl1.AddFlight(requestor, flight2);
            empl1.AddFlight(requestor, flight3);
            empl1.Undo(requestor);
            empl1.AddFlight(requestor, flight4);

            //requestor.Route.ShowFlights();
            Console.ReadKey();

            //Strategy
            requestor.Route.SetCalculationStrategy(new CalculatePrimeMethod());
            Console.WriteLine($"Total route price is {requestor.Route.CalculatePrice()}");
            Console.ReadKey();

            //Observer
            ShiftManager shiftManager = new ShiftManager();
            foreach(Employee empl in groupA.employees)
            {
                shiftManager.Attach(empl);
            }

            Shift nightShift = new Shift("night", "17:00", "23:00");
            shiftManager.SetNewShift(nightShift);
            
            Console.ReadKey();
        }
    }
}
