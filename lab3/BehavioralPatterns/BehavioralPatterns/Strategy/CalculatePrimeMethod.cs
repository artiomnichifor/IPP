using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralPatterns.Entitites;

namespace BehavioralPatterns.Strategy
{
    class CalculatePrimeMethod : ICalculateRoutePrice
    {
        public double CalculatePrice(List<Flight> flights)
        {
            double sum = 0;
            foreach (Flight fl in flights)
            {
                sum += fl.Price;
            }
            sum = sum * 0.9;
            return sum;
        }
    }
}
