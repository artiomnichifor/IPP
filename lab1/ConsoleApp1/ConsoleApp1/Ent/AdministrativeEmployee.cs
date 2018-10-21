using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ent
{
    public class AdministrativeEmployee : Employee
    {
        public string AdministrativeRights { get; }

        public AdministrativeEmployee(string firstName, string lastName, string email, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException($"{nameof(firstName)} is null or empty");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException($"{nameof(lastName)} is null or empty");
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException($"{nameof(email)} is null or empty");
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException($"{nameof(phoneNumber)} is null or empty");

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.AdministrativeRights = "admin";
        }
    }
}
