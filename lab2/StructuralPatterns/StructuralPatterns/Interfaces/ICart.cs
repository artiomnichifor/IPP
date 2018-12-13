using StructuralPatterns.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Interfaces
{
    interface ICart
    {
        void Add(Product p);
        void Remove(Product p);
        double GetTotalPrice();
    }
}
