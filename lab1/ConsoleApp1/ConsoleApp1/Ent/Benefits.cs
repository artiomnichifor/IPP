using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ent
{
    public abstract class Benefits
    {
        public int FoodExpenses { get; set; }
        public int GymExpenses { get; set; }
        public int ExtraExpenses { get; set; }

        public abstract int Average();


    }
}
