using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatterns.Ent;

namespace StructuralPatterns.Bridge
{
    class PersonalDataEditor : IPersonalDataEditor
    {
        public void EditName(PersonalData pd)
        {
            string fn, ln;
            string dateString;
            DateTime date;
            Console.WriteLine($"Modificarea numelui, introduceti ziua de nastere:");
            dateString = Console.ReadLine();
            date = Convert.ToDateTime(dateString);
            if (DateTime.Compare(date, pd.DateOfBirth) == 0)
            {
                Console.WriteLine("Prenumele:");
                fn = Console.ReadLine();
                Console.WriteLine("Numele:");
                ln = Console.ReadLine();
                pd.firstName = fn;
                pd.lastName = ln;

            }
            else
            {
                Console.WriteLine("Data introdusa incorect");
            }
        }

        public void ShowData(PersonalData pd)
        {
            Console.WriteLine($"Numele: {pd.firstName} {pd.lastName}");
            Console.WriteLine($"Data de nastere: {pd.DateOfBirth}");
            Console.WriteLine($"Data ultemei cumparaturi: {pd.lastTimePurchased}");

        }

        public void Purchase(PersonalData pd)
        {
            pd.lastTimePurchased = DateTime.Now;
        }
    }
}
