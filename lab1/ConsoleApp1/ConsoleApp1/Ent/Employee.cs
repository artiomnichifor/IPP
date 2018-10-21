using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ent
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfEmployment { get; set; } = DateTime.Now;

        public Salary Salary { get; set; }
        public Benefits Benefits { get; set; }
        public Shift Shift { get; set;}
    }
}
