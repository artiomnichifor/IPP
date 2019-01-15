using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Entitites
{
    abstract class Group
    {
        protected Group successor;

        public string Name { get; set; }
        public string Target { get; set; }

        public List<Employee> employees = new List<Employee>();
        public List<Requestor> requestors = new List<Requestor>();

        public Group(string name, string target)
        {
            this.Name = name;
            this.Target = target;

            employees.Add(new Employee
            {
                Name = string.Concat("Ana ", Name),
                Position = "Manager"
            });
            employees.Add(new Employee
            {
                Name = string.Concat("Ion ", Name),
                Position = "Receiver"
            });
            employees.Add(new Employee
            {
                Name = string.Concat("Maria ", Name),
                Position = "FlightBuilder"
            });
            employees.Add(new Employee
            {
                Name = string.Concat("Vlad ", Name),
                Position = "Support"
            });
        }

        public void SetSuccessor(Group successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(Requestor req);

    }
}
