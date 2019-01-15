using StructuralPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    abstract class Decorator : IProduct
    {
        protected IProduct product;

        public Decorator(IProduct product)
        {
            this.product = product;
        }

        public string Name
        {
            get
            {
                return product.Name;
            }

            set
            {
                product.Name = value;
            }
        }

        public double Price
        {
            get
            {
                return product.Price;
            }

            set
            {
                product.Price = value;
            }
        }

        public void SetComponent(IProduct product)
        {
            this.product = product;
        }

        public virtual void ShowData()
        {
            if(product != null)
            {
                product.ShowData();

            }
        }
    }
}
