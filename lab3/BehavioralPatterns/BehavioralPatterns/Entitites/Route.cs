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

        List<Flight> flights = new List<Flight>();
    }
}
