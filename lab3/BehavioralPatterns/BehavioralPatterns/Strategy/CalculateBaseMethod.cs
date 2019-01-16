using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralPatterns.Entitites;

namespace BehavioralPatterns.Strategy
{
    class CalculateBaseMethod : ICalculateRoutePrice
    {
        public double CalculatePrice(List<Flight> flights)
        {
            double sum = 0;
            foreach(Flight fl in flights)
            {
                sum += fl.Price;
            }
            return sum;
        }
    }
}
