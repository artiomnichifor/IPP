using ConsoleApp1.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ent
{
    public class CommonEvent : EventPrototype
    {
        List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public override EventPrototype Clone()
        {
            return this.MemberwiseClone() as EventPrototype;
        }
    }
}
