using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatterns.Ent;

namespace StructuralPatterns.Flyweight
{
    class OneYearUserBonus : IBonus
    {
        public void AddBonus(Client c)
        {
            c.TopUpAccount(20);
        }


    }
}
