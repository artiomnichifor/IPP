using StructuralPatterns.Ent;
using StructuralPatterns.Interfaces;
using StructuralPatterns.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    class ProductAdapter : ProductSystem, ITarget
    {
        public double GetAveragePrice()
        {
            double avg = 0;
            int nr = 0;
            List<IProduct> products = GetAllProducts();
            foreach (var p in products)
            {
                avg += p.Price;
                nr++;
            }
            avg = avg / nr;
            return avg;
        }

        public List<string> GetProductNameList()
        {
            List<string> nameList = new List<string>();
            List<IProduct> products = GetAllProducts();
            foreach(var p in products)
            {
                nameList.Add(p.Name);
            }
            return nameList;
        }
    }
}
