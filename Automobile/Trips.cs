using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public class Trips
    {
        public decimal DistanceToCover { get; }
        public string Destination { get; }
        public Trips(decimal distanceToCover, string destination)
        {
            this.DistanceToCover = distanceToCover;
            this.Destination = destination;
        }
    }
}
