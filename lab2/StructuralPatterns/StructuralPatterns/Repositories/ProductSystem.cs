using StructuralPatterns.Decorator;
using StructuralPatterns.Ent;
using StructuralPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Repositories
{
    class ProductSystem
    {
        public ProductSystem()
        {
            products.Add(new Product
            {
                Name = "name1",
                DoP = DateTime.Now,
                Price = 8,
                Description = "desc1"  
            });
            LimitedEditionProduct limitedEditionProduct1 = new LimitedEditionProduct(new Product
            {
                Name = "name2",
                DoP = DateTime.Now,
                Price = 8,
                Description = "desc2"
            });
            limitedEditionProduct1.endOfProotion = new DateTime(2020, 1, 1);
            products.Add(limitedEditionProduct1);
            products.Add(new Product
            {
                Name = "name3",
                DoP = DateTime.Now,
                Price = 3,
                Description = "desc3"
            });
        }

        List<IProduct> products = new List<IProduct>();

        public List<IProduct> GetAllProducts()
        {
            return products;
        }

        public void AddProduct(IProduct p)
        {
            products.Add(p);
        }

        public void RemoveProduct(IProduct p)
        {
            products.Remove(p);
        }
    }
}
