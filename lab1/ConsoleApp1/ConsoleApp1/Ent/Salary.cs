using ConsoleApp1.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ent
{
    public abstract class Salary
    {
        public int WorkingHours { get; set; }
        public int SalaryPerHour { get; set; }

        public abstract int GetSalary(Benefits benefits);
    }
}
