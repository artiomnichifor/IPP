using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Interfaces
{
    interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }

        void ShowData();
    }
}
