using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    public struct Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Planet Planet { get; set; }

        public Location(double latitude, double longitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            return this.Latitude + ", " + this.Longitude + " - " + this.Planet;
        }
    }
}
