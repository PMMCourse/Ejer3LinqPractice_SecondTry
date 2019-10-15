using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ejer3LinqPractice_SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            var archivoJ = File.ReadAllText("Cars.json"); //Cargamos el archivo.

            List<Cars> coches = JsonConvert.DeserializeObject<List<Cars>>(archivoJ); //Creamos una lista con el json.

        }

        static void Ejer4(List<Cars> lc)
        {
            var fm = lc.Where(x => x.Color == "Fuscia").Select(y => new { Fabricante = y.Maker, Modelo = y.Model });

            foreach(var i in fm)
            {
                Console.WriteLine($"Fabricante: {i.Fabricante} Modelo: {i.Modelo}");
            }
        }

        static void Ejer5(List<Cars> lc)
        {
            var lat = 0.0;
            var lon = 0.0;

            Console.WriteLine("Introduce una latitud: ");
            lat = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce una longitud: ");
            lon = double.Parse(Console.ReadLine());

            var query = lc.Where(x => x.Loc.Latitude == lat && x.Loc.Latitude == lon).Any(y => y.Color == "Turquoise");

            if (query)
            {
                Console.WriteLine("Si hay coches");
            }
            else
            {
                Console.WriteLine("No hay coches");
            }
        }


        static void Ejer7(List<Cars> lc)
        {
            var query = lc.Where(x => x.Loc.Latitude == null && x.Loc.Longitude == null)
                .Select(y => new CocheEspecifico { Maker = y.Maker, Model = y.Model });

            foreach(var i in query)
            {
                Console.WriteLine($"Fabricante: {i.Maker} Fabricante: {i.Model}");
            }
        }

        static void Ejer10(List<Cars> lc)
        {
            var cpf = lc.GroupBy(x => x.Maker);

            foreach(var i in cpf)
            {
                Console.WriteLine($"Fabricante: {i.Key}");

                foreach(var j in i)
                {       
                    if(j.Color != null) //SI NO TIENE, NO LO MUESTRO.
                    {
                        Console.WriteLine($"Color: {j.Color}");
                    }                 
                }
            }

        }
    }
}
