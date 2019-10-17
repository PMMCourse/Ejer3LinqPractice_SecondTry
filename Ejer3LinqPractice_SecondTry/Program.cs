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
        static List<Cars> listaCoche = new List<Cars>();

        static Cars objCars = new Cars();

        static List<Cars> ListaCoche()
        {
            using (StreamReader r = new StreamReader("Cars.json"))
            {
                string json = r.ReadToEnd();
                listaCoche = JsonConvert.DeserializeObject<List<Cars>>(json);
                return listaCoche;
            }
        }

        static void Ejer4() => Console.WriteLine(listaCoche.Where(x => x.Color.Equals("Fuscia")));
        static void Ejer5()
        {
            float? latitude, longitude;

            Console.WriteLine("Latitud: ");
            
            latitude = float.Parse(Console.ReadLine());
            latitude = objCars.gsLocation.Latitude;

            Console.WriteLine("Longitud: ");

            longitude = float.Parse(Console.ReadLine());
            longitude = objCars.gsLocation.Longitude;

            var f = listaCoche.Find(x => x.Color.Equals("Turquoise") && x.gsLocation.Latitude == latitude && x.gsLocation.Longitude == longitude);
        }
        static void Ejer7()
        {
            // Ni idea
        }
        static void Ejer10() => Console.WriteLine(listaCoche.GroupBy(x => x.Maker)); // Me falta mostrar colores sin duplicar
        static void Main(string[] args)
        {
        }
    }
}
