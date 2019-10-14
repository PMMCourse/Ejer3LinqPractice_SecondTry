using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice_SecondTry
{
    class Cars
    {
        public int id { get; set; }

        public string Maker { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public struct Location
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }
    }
}
