using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ejer3LinqPractice_SecondTry
{
    class Cars
    {
        [JsonProperty("Maker")]
        public string Fabricante { get; set; }
        [JsonProperty("Model")]
        public string Modelo { get; set; }
        [JsonProperty("Year")]
        public int? Anio { get; set; }
        public string Color { get; set; }
        public Location Loc { get; set; }

        //CREAR TIPO STRUCT PARA EL JSON:
        public struct Location
        {
             [JsonProperty("Latitude")]
             public double? Latitud { get; set; }
             [JsonProperty("Longitude")]
             public double? Longitud { get; set; }

        }

    }
}
