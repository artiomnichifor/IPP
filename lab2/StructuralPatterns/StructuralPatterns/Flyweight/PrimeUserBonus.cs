using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatterns.Ent;

namespace StructuralPatterns.Flyweight
{
    class PrimeUserBonus : IBonus
    {
        public void AddBonus(Client c)
        {
            c.AddDiscountBonus("prime_user", 10);
        }
    }
}
