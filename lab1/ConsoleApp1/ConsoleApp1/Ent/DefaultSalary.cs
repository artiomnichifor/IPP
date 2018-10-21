using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ent
{
    class DefaultSalary : Salary
    {
        public DefaultSalary(int workingHours, int salaryPerHour)
        {
            if (workingHours <= 0)
                throw new ArgumentException($"{nameof(workingHours)} is not positive");
            if (salaryPerHour <= 0)
                throw new ArgumentException($"{nameof(salaryPerHour)} is not positive");

            this.WorkingHours = workingHours;
            this.SalaryPerHour = salaryPerHour;
        }

        public int Wage() => WorkingHours * SalaryPerHour;

        public override int GetSalary(Benefits benefits)
        {
            return benefits.Average() + Wage();
        }
    }
}
