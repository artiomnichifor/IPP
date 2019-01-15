using StructuralPatterns.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatterns.Repositories;
using StructuralPatterns.Decorator;
using StructuralPatterns.Adapter;
using StructuralPatterns.Interfaces;
using StructuralPatterns.Flyweight;

namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductSystem productSystem = new ProductSystem();
            ClientSystem clientSystem = new ClientSystem();
            ProductAdapter productAdapter = new ProductAdapter();
            BillingStatisticsSystem statisticsSystem = new BillingStatisticsSystem(productAdapter);
            BonusFactory bonusFactory = new BonusFactory();

            Client client1 = new Client("Ina", "Munteanu", new DateTime(1996, 1, 1));
            clientSystem.AddClient(client1);
            Client client2 = new Client("Maria", "Zeru", new DateTime(1997, 1, 1));
            clientSystem.AddClient(client2);


            Product product1 = new Product();
            product1.Name = "name1";
            product1.Price = 8;
            product1.DoP = DateTime.Now;
            productSystem.AddProduct(product1);

            Product product2 = new Product();
            product2.Name = "name2";
            product2.Price = 12;
            product2.DoP = DateTime.Now;

            //Decorator
            LimitedEditionProduct limitedEditionProduct1 = new LimitedEditionProduct(product2);
            limitedEditionProduct1.endOfProotion = new DateTime(2020, 1, 1);
            productSystem.AddProduct(limitedEditionProduct1);

            Product product3 = new Product();
            product3.Name = "name3";
            product3.Price = 3;
            product3.DoP = DateTime.Now;
            productSystem.AddProduct(product3);


            //Flyweight
            Console.WriteLine("\nFlyweight:");
            IBonus bonus = bonusFactory.GetBonus("PrimeUserBonus");
            bonus.AddBonus(client2);
            client2.ShowDiscountData();


            //Bridge
            Console.WriteLine("\nBridge:");
            //client1.ShowPersonalData();
            //client1.EditPersonalData();
            //client1.ShowPersonalData();


            //Adapter
            Console.WriteLine("\nAdapter:");
            statisticsSystem.ShowProductsNameList();
            statisticsSystem.ShowAveragePrice();

            //Decorator
            Console.WriteLine("\nDecorator:");
            limitedEditionProduct1.ShowData();


            //Facade
            Console.WriteLine("\nFacade:");
            //client1.SetClientDiscountStatus();
            bonus.AddBonus(client1);
            client1.AddToCart(product1);
            client1.AddToCart(limitedEditionProduct1);
            client1.TopUpAccount(21);
            client1.GetThePurchaseInfo();
            client1.Purchase();

            //client1.ShowBallanceData();


            Console.ReadKey();

        }
    }
}
