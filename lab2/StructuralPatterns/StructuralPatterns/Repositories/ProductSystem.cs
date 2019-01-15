using StructuralPatterns.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Repositories
{
    class ProductSystem
    {
        List<Product> products = new List<Product>();

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public void RemoveProduct(Product p)
        {
            products.Remove(p);
        }
    }
}
