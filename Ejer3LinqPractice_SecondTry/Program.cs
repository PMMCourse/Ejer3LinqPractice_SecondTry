using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice_SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            String archivo = File.ReadAllText("Cars.json");
            List<Car> cochesito = JsonConvert.DeserializeObject<List<Car>>(archivo);
            Ej4(cochesito);
            Ej5(cochesito);
            Console.ReadKey();
        }
        public static void Ej4(List<Car> cochesio)
        {
            var colorCar = cochesio.Where(x => x.color == "Fuscia");
            foreach (var a in colorCar)
            {
                Console.WriteLine("Marca: " + a.maker + " Modelo: " + a.model);
            }
        }

       public static void Ej5(List<Car> cochesito)
        {
            Console.WriteLine("Inroduzca una Latitud: ");
            Double latitud=Double.Parse(Console.ReadLine());
            Console.WriteLine("Inroduzca una Longitud: ");
            Double longi = Double.Parse(Console.ReadLine());
            var colorCar = cochesio.Where(x => x.location1.Latitude == latitud && x.location1.Longitude == longi && x.color== "Turquoise");

            foreach (var a in colorCar)
            {
                Console.WriteLine("Marca: " + a.maker + " Modelo: " + a.model);
            }
        }
        public static void Ej7(List<Car> cochesito){


        }

    }
}
