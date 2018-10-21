using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Ent;

namespace ConsoleApp1.AbstractFactory
{
    class DefaultBranchPaymentFactory : PaymentFactory
    {
        public override Benefits CreateBenefits(int extraExpenses)
        {
            // assigns default values for food and gym expenses
            return new DefaultBenefits(40, 80, extraExpenses);
        }

        public override Salary CreateSalary(int workingHours, int salaryPerHour)
        {
            return new DefaultSalary(workingHours, salaryPerHour);
        }
    }
}
