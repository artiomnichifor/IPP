using BehavioralPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Entitites
{
    class Route
    {
        public string Name { get; set; }

        private readonly List<Flight> flights;

        private ICalculateRoutePrice calculationStrategy;

        public Route()
        {
            flights = new List<Flight>();
        }

        public void SetCalculationStrategy(ICalculateRoutePrice calculationStrategy)
        {
            this.calculationStrategy = calculationStrategy;
        }

        public double CalculatePrice()
        {
            return calculationStrategy.CalculatePrice(flights);
        }

        public void AddFlight(Flight fl)
        {
            flights.Add(fl);
        }

        public void RemoveFlight(Flight fl)
        {
            flights.Remove(fl);
        }
        public void RemoveFlight()
        {
            flights.Remove(flights.Last());
        }

        public void ShowFlights()
        {
            foreach(Flight fl in flights)
            {
                Console.WriteLine(fl.Price);
            }
        }

    }
}
