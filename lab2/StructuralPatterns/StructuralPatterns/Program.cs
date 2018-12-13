using StructuralPatterns.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Product product1 = new Product();

            product1.Id = 101;
            product1.Name = "name1";
            product1.Price = 8;
            product1.DoP = DateTime.Now;

            Product product2 = new Product();

            product2.Id = 101;
            product2.Name = "name1";
            product2.Price = 12;
            product2.DoP = DateTime.Now;

            client.AddToCart(product1);
            client.AddToCart(product2);

            client.SetClientDiscountStatus();

            client.TopUpAccount(21);
            client.GetThePurchaseInfo();



            Console.ReadKey();

        }
    }
}
