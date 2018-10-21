using System;
using ConsoleApp1.Ent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Builder;
using ConsoleApp1.FactoryMethod;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();

            

            //Factory Method for creating an administrative employee
            var adminEmployee = service.CreateAdministrativeEmployee("FN", "LN", "mail@mail.com", "00000");

            //Abstract Factory for creating benefits and salary
            service.SetSalaryAndBenefits(adminEmployee, 160, 10, 100);
            service.GetSalary(adminEmployee);

            //Builder for shift setter
            service.SetMorningShift(adminEmployee);

            //Prototype and Singleton
            service.CreateEvent("Empl. #00451 birthday", new DateTime(2018, 12, 12, 18, 0, 0), TimeSpan.FromHours(1), "Best birthday like ever");
            service.AddAttendant("Empl. #00451 birthday", adminEmployee);

            Console.WriteLine("Hullo World!");
            Console.ReadKey();
        }
    }
}
