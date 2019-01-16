using StructuralPatterns.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Interfaces
{
    abstract class AbstractPersonalData
    {
        public IPersonalDataEditor PersonalDataEditor { get; set; }

        public AbstractPersonalData()
        {
            this.PersonalDataEditor = new PersonalDataEditor();
        }

        public virtual void Purchase() { }
        public virtual void EditName() { }
        public virtual void ShowData() { }
    }
}
