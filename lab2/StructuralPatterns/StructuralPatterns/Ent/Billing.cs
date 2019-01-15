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
        double TotalAmountOfMoney;
        string CustomerStatus;
        int CustomerDiscount;
        int numberOfPurchases;

        public Billing()
        {
            TotalAmountOfMoney = 0;
            CustomerDiscount = 0;
            CustomerStatus = null;
            numberOfPurchases = 0;
        }

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
        }

        public void Purchase(double price)
        {
            TotalAmountOfMoney -= price;
            numberOfPurchases += 1;
        }

        public void ShowDiscountData()
        {
            Console.WriteLine($"Status: {CustomerStatus}");
            Console.WriteLine($"Discount: {CustomerDiscount}");

        }

        public void ShowBallanceData()
        {
            Console.WriteLine($"Ballance: {TotalAmountOfMoney}");
        }
    }
}
