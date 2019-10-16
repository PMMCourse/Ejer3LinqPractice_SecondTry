using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ejer3LinqPractice_SecondTry
{
    class CocheEspecifico
    {
        //CLASE PARA EL EJ 7.
        [JsonProperty("Maker")]
        public string Fabricante { get; set; }
        [JsonProperty("Model")]
        public string Modelo { get; set; }
    }
}
