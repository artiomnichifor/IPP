using StructuralPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Ent
{
    class Client
    {
        IPersonalData personalData;
        IBilling billing;
        ICart cart;

        public Client()
        {
            personalData = new PersonalData();
            billing = new Billing();
            cart = new Cart();
        }

        public void AddToCart(Product p)
        {
            cart.Add(p);
        }

        public void RemoveFromCart(Product p)
        {
            cart.Remove(p);
        }

        public void TopUpAccount(double m)
        {
            billing.TopUp(m);
        }

        public void GetThePurchaseInfo()
        {
            double price = cart.GetTotalPrice();
            if (billing.CompareWithBallance(price))
            {
                Console.WriteLine($"Suma disponibila: {billing.GetBallance()}");
                Console.WriteLine($"Suma destinata achitarii {cart.GetTotalPrice()}");
                Console.WriteLine($"Suma cu reducere: {billing.CutTheDiscount(price)}");
            }
            else
            {
                Console.WriteLine("Resursele financiare sunt prea putine, supliniti contul!");
            }
        }
        public void SetClientDiscountStatus()
        {
            Console.Write("Status: ");
            string  s = Console.ReadLine();
            Console.Write("Discount: ");
            string ds = Console.ReadLine();
            int d = Int32.Parse(ds);

            if (d > 50)
            {
                Console.WriteLine("Reducerea prea mare (max50%)");
                Console.ReadKey();
            }
            else
            {
                billing.SetTheDiscountStatus(s, d);
            }
        }

    }
}
