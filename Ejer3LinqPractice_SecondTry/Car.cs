using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice_SecondTry
{
    class Car
    {
        public int id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int? year { get; set; }
        public string color { get; set; }
        public location location1 { get; set; }
        public struct location
        {
            public double? Latitude { get; set; }

            public double? Longitude { get; set; }
        }
    }
}

