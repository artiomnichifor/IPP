using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    class BillingStatisticsSystem
    {
        private ITarget productSource;

        public BillingStatisticsSystem(ITarget clientSource)
        {
            this.productSource = clientSource;
        }

        public void ShowProductsNameList()
        {
            List<string> names = productSource.GetProductNameList();
            Console.WriteLine("Lista cu numele produselor:");
            foreach(string s in names)
            {
                Console.Write(s);
                Console.Write(", ");
            }
            Console.Write("\n");

        }

        public void ShowAveragePrice()
        {
            Console.WriteLine($"Pretul mediu este {productSource.GetAveragePrice()}");
        }
    }
}
