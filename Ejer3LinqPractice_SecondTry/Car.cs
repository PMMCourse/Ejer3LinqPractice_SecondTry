using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice_SecondTry
{
    public class Car
    {
        public int id { get; set; }

        public string Maker { get; set; }

        public string Model { get; set; }

        public int? Year { get; set; }

        public string Color { get; set; }
        public Location location { get; set; }
        
        public struct Location
        {
            public Location(double lat, double longi)
            {
                Latitude = lat;
                Longitude = longi;
            }

            public double? Latitude { get; set; }
            public double? Longitude { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                var loc = (Location)obj;
                return loc.Latitude == this.Latitude &&
                    loc.Longitude == this.Longitude;                
            }
        }

        public override string ToString()
        {            
            return $"id: {id}, Maker: {Maker}, Model: {Model}, Year: {Year}, Color: {Color}" +
                $", Latitud: {location.Latitude}, Longitud: {location.Longitude}";
        }
    }
}
