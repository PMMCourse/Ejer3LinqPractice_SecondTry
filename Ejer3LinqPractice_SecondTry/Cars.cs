using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice_SecondTry
{
    class Cars
    {
        public override string ToString()
        {
            return "Maker: " + this.Maker + "\nModel: " + this.Model + "\nYear: " + this.Year + "\nColor: " + this.Color + "\nLocation: " + this.gsLocation;
        }
        public string Maker { get; set; }
        public string Model { get; set; }
        public short? Year { get; set; }
        public string Color { get; set; }
        public Location gsLocation { get; set; }
        public struct Location
        {
            public float? Latitude { get; set; }
            public float? Longitude { get; set; }
        }

    }
}
