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
        void Add(IProduct p);
        void Remove(IProduct p);
        double GetTotalPrice();
        void Purchase();
        void WriteProductsName();
    }
}
