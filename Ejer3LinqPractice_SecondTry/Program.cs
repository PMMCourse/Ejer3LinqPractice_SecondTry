using System;
using System.IO;
using System.Collections.Generic;
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
            String archivo = File.ReadAllText("Cars.json");
            List<Car> coches = JsonConvert.DeserializeObject<List<Car>>(archivo);
            Ejer4(coches);
            Console.ReadKey();
        }

        public static void Ejer4(List<Car> coche) {
            var ej4 = coche.Where(x => x.Color=="Fuscia");

            foreach (var a in ej4)
            {
                    Console.WriteLine($"Fabricante:{a.Maker}  Modelo:{a.Model}");
            }
        }


    }
}
