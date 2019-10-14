using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Ejer3LinqPractice_SecondTry
{
    class Program
    {
        /*
         * ENUNCIADOS
         * 
         4.- Muestra fabricante y modelo. Del color Fuscia.
         5.- Permite al usuario introducir una latitud y una longitud. Indica al usuario si encuentra un coche de color Turquoise dentro de esa latitud y longitud facilitada.
         7.- Genera una nueva clase con modelo y fabricante. Muestra todos los coches que no tengan latitud, ni longitud Convierte en la búsqueda a esa clase.
        10.- Agrupa todos los coches por fabricante, muestra los colores disponibles sin duplicar la muestra.
         */

            public static List<Cars> lista()
        {
            String ruta = Path.GetFullPath("Cars.json");//Obtengo de la ruta relativa la absoluta
            StreamReader jsonStream = File.OpenText(ruta);
            var json = jsonStream.ReadToEnd();
            //lo decodifico del formato JSON y lo guardo en una lista de heroes
            List<Cars> coches = JsonConvert.DeserializeObject<List<Cars>>(json);
            return coches;
        }

        public void EJer4()
        {

        }

        public void EJer5()
        {

        }
        public void EJer7()
        {

        }
        public void EJer10()
        {

        }
        static void Main(string[] args)
        {
            //EJer4
            //EJer5
            //EJer7
            //EJer10
        }
    }
}
