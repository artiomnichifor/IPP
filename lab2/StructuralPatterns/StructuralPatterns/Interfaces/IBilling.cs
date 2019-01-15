using StructuralPatterns.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Interfaces
{
    interface IBilling
    {
        bool CompareWithBallance(double p);
        double GetBallance();
        double CutTheDiscount(double p);
        void TopUp(double m);
        void SetTheDiscountStatus(string s, int d);
        void Purchase(double price);
    }
}
