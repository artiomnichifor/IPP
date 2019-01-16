using StructuralPatterns.Bridge;
using StructuralPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Ent
{
    class PersonalData : AbstractPersonalData
    {      

        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime lastTimePurchased { get; set; }


        public PersonalData(string fn, string ln, DateTime dob) : base()
        {
            this.DateOfBirth = dob;
            this.firstName = fn;
            this.lastName = ln;
            
        }

        public override void EditName()
        {
            PersonalDataEditor.EditName(this);
        }

        public override void Purchase()
        {
            PersonalDataEditor.Purchase(this);
        }

        public override void ShowData()
        {
            PersonalDataEditor.ShowData(this);
        }

    }
}
