using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ent
{
    class DefaultBenefits : Benefits
    {


        public DefaultBenefits(int foodExpenses, int gymExpenses, int extraExpenses)
        {
            if (foodExpenses <= 0)
                throw new ArgumentException($"{nameof(foodExpenses)} is not positive");
            if (gymExpenses <= 0)
                throw new ArgumentException($"{nameof(gymExpenses)} is not positive");
            if (extraExpenses <= 0)
                throw new ArgumentException($"{nameof(extraExpenses)} is not positive");

            this.FoodExpenses = foodExpenses;
            this.GymExpenses = gymExpenses;
            this.ExtraExpenses = extraExpenses;
        }

        public override int Average() => FoodExpenses + GymExpenses + ExtraExpenses;


    }
}
