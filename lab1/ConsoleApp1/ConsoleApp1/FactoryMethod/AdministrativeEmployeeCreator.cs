using ConsoleApp1.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryMethod
{
    class AdministrativeEmployeeCreator : EmployeeCreator  <AdministrativeEmployee>
    {
        public override AdministrativeEmployee FactoryMethod(string firstName, string lastName, string email, string phoneNumber)
        {
            return new AdministrativeEmployee(firstName, lastName, email, phoneNumber);
        }
    }
}
