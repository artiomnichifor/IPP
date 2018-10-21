using ConsoleApp1.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstractFactory
{
    abstract class PaymentFactory
    {
        public abstract Salary CreateSalary(int workingHours, int salaryPerHour);
        public abstract Benefits CreateBenefits(int extraExpenses);
    }
}
