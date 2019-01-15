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

        public Client(string fn, string ln, DateTime dob)
        {
            personalData = new PersonalData(fn, ln, dob);
            billing = new Billing();
            cart = new Cart();
        }

        public void AddToCart(IProduct p)
        {
            cart.Add(p);
        }

        public void RemoveFromCart(IProduct p)
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
                Console.Write("Lista de cumparaturi:");
                cart.WriteProductsName();
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

        public void Purchase()
        {
            billing.Purchase(billing.CutTheDiscount(cart.GetTotalPrice()));
            personalData.Purchase();
            cart.Update();
            Console.WriteLine($"Suma ramasa: {billing.GetBallance()}");
        }

        public void EditPersonalData()
        {
            personalData.EditName();
        }

        public void ShowPersonalData()
        {
            personalData.ShowData();
        }

    }
}
