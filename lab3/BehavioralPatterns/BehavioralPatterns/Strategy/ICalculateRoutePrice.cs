using BehavioralPatterns.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy
{
    interface ICalculateRoutePrice
    {
        double CalculatePrice(List<Flight> flights);

    }
}
