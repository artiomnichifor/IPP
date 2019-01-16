using BehavioralPatterns.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command
{
    interface ICommand
    {
        void AddFlight(Requestor req, Flight fl);
        void RemoveFlight(Requestor req);
    }
}
