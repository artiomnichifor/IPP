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
        List<Product> products = new List<Product>();

        public void Add(Product p)
        {
            products.Add(p);
        }

        public void Remove(Product p)
        {
            products.Remove(p);
        }

        public double GetTotalPrice()
        {
            double price = 0;
            foreach(Product p in products)
            {
                price += p.Price;
            }
            return price;
        }
    }
}
