using ConsoleApp1.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryMethod
{
    abstract class EmployeeCreator <T> where T : Employee
    {
        public abstract T FactoryMethod(string firstName, string lastName, string email, string phoneNumber);

    }
}
