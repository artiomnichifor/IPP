using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Entitites
{
    class Group
    {
        public string Name { get; set; }

        List<Employee> employees = new List<Employee>();
    }
}
