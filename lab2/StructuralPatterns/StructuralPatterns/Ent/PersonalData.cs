using StructuralPatterns.Bridge;
using StructuralPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Ent
{
    class PersonalData : IPersonalData
    {      

        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime lastTimePurchased { get; set; }

        IPersonalDataEditor PersonalDataEditor { get; set; }

        public PersonalData(string fn, string ln, DateTime dob)
        {
            this.DateOfBirth = dob;
            this.firstName = fn;
            this.lastName = ln;
            this.PersonalDataEditor = new PersonalDataEditor();
        }

        public void EditName()
        {
            PersonalDataEditor.EditName(this);
        }

        public void Purchase()
        {
            PersonalDataEditor.Purchase(this);
        }

        public void ShowData()
        {
            PersonalDataEditor.ShowData(this);
        }

    }
}
