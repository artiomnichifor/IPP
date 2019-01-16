using BehavioralPatterns.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command
{
    class RouteCreator : ICommand
    {
        protected Route route;

        public RouteCreator(Route route)
        {
            this.route = route;
        }

        public void AddFlight(Requestor req, Flight fl)
        {
            req.Route.AddFlight(fl);

        }

        public void RemoveFlight(Requestor req)
        {
            req.Route.RemoveFlight();


        }
    }
}
