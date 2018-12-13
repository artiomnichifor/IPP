using StructuralPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Ent
{
    class Billing : IBilling
    {
        public double TotalAmountOfMoney { get; set; }
        public string CustomerStatus { get; set; }
        public int CustomerDiscount { get; set; } 

        public bool CompareWithBallance(double p)
        {
            return p < TotalAmountOfMoney;
        }

        public double GetBallance()
        {
            return TotalAmountOfMoney;
        }

        public double CutTheDiscount(double p)
        { 
            return p - p * CustomerDiscount / 100;
        }

        public void TopUp(double m)
        {
            TotalAmountOfMoney += m;
        }

        public void SetTheDiscountStatus(string s, int d)
        {
            CustomerStatus = s;
            CustomerDiscount = d;
            Console.Write(CustomerDiscount);
        }
    }
}
