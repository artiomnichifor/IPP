using StructuralPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    class LimitedEditionProduct : Decorator
    {
        public DateTime EndOfPromotion { get; set; }

        public LimitedEditionProduct(IProduct product) : base (product)
        {

        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Data limita a promotiei: {EndOfPromotion}");
        }
    }
}
