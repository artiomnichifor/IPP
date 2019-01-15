using StructuralPatterns.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    interface IPersonalDataEditor
    {
        void EditName(PersonalData pd);
        void ShowData(PersonalData pd);
        void Purchase(PersonalData pd);

    }
}
