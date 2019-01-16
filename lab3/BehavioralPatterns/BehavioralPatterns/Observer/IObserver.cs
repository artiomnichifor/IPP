using BehavioralPatterns.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Observer
{
    interface IObserver
    {
        void Update(Shift shift);

    }
}
