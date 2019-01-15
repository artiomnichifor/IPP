using BehavioralPatterns.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.St
{
    interface IState
    {
        void Proceed(Requestor req);
    }
}
