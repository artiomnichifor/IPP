using StructuralPatterns.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatterns.Repositories;
using StructuralPatterns.Decorator;


namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductSystem productSystem = new ProductSystem();
            ClientSystem clientSystem = new ClientSystem();
            Client client = new Client("Ina", "Munteanu", new DateTime(1996, 1, 1));

            clientSystem.AddClient(client);

            //Bridge
            //client.ShowPersonalData();
            //client.EditPersonalData();
            //client.ShowPersonalData();

            Product product1 = new Product();
            product1.Name = "name1";
            product1.Price = 8;
            product1.DoP = DateTime.Now;

            client.AddToCart(product1);

            Product product2 = new Product();
            product2.Name = "name2";
            product2.Price = 12;
            product2.DoP = DateTime.Now;

            LimitedEditionProduct limitedEditionProduct1 = new LimitedEditionProduct(product2);
            limitedEditionProduct1.endOfProotion = new DateTime(2020, 1, 1);

            limitedEditionProduct1.ShowData();

            client.AddToCart(limitedEditionProduct1);

            //client.SetClientDiscountStatus();

            //client.TopUpAccount(21);
            //client.GetThePurchaseInfo();
            //client.Purchase();


            Console.ReadKey();

        }
    }
}