using StructuralPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Ent
{
    class Cart : ICart
    {
        List<IProduct> products = new List<IProduct>();

        public void Add(IProduct p)
        {
            products.Add(p);
        }

        public void Remove(IProduct p)
        {
            products.Remove(p);
        }

        public double GetTotalPrice()
        {
            double price = 0;
            foreach(var p in products)
            {
                price += p.Price;
            }
            return price;
        }

        public void WriteProductsName()
        {
            foreach(var p in products)
            {
                Console.Write(p.Name);
            }
            Console.Write("\n");
        }

        public void Purchase()
        {
            //set some data about last purchase
            //
            //

        }
    }
}
