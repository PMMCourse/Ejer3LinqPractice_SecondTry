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

        public override string ToString()
        {
            return string.Format($"id: {id}, Maker: {Maker}, Model: {Model}, Year: {Year}, Color: {Color}" +
                $", Latitud: {location.Latitude}, Longitud: {location.Longitude}");
        }
        public struct Location
        {
            public double? Latitude { get; set; }
            public double? Longitude { get; set; }
        }
    }
    
}
