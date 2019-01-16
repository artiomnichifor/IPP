using BehavioralPatterns.Command;
using BehavioralPatterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Entitites
{
    class Employee : IObserver
    {
        private Shift shift;

        private List<ICommand> commands = new List<ICommand>();
        private Route route = new Route();
        private int current = 0;

        public string Name { get; set; }
        public string Position { get; set; }

        public void AddFlight(Requestor req, Flight fl)
        {
            ICommand command = new RouteCreator(route);
            command.AddFlight(req, fl);

            commands.Add(command);
            current++;
        }

        public void Undo(Requestor req)
        {       
            ICommand command = commands[--current] as ICommand;
            command.RemoveFlight(req);
        }

        public void Update(Shift shift)
        {
            this.shift = shift;
            Console.WriteLine(string.Format("Employee {0} - New shift: {1}", Name, shift.ShowShiftData()));
        }
    }
}
