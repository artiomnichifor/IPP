using StructuralPatterns.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    interface ITarget
    {
        List<string> GetClientsNameList();
        double GetAverageBallance();
        double GetAverageNumberOfPurchases();
    }
}
