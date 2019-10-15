using System;
using System.Resources;
using System.IO;
using System.Collections;
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
            string resxFile = "messages.resx";
            List<Car> coches = JsonConvert.DeserializeObject<List<Car>>(archivo);
            Ejer5(coches,resxFile);
            Console.ReadKey();
        }

        public static void Ejer4(List<Car> coche) {
            var ej4 = coche.Where(x => x.Color=="Fuscia");

            foreach (var a in ej4)
            {
                    Console.WriteLine($"Fabricante:{a.Maker}  Modelo:{a.Model}");
            }
        }

        public static void Ejer5(List<Car> coche, string resxFile)
        {
            Console.WriteLine($"Introduce una latitud para buscar:");
            double latitud = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Introduce una longitud para buscar:");
            double longitud = Convert.ToDouble(Console.ReadLine());
            var ej5 = coche.Where(x => x.Color == "Turquoise" /*& x.location.Latitude==latitud & x.location.Longitude==longitud*/);
            //using (ResourceReader resxReader = new ResourceReader(resxFile))
            //{
                foreach (var a in ej5)
                {
                    //La intención era mandar el objeto que cumpliera la lambda y mostrarlo a través de un fichero de recursos
                    //y así no tener que redefinir métodos o escribir la misma salida, pero no he conseguido pasarle valores a
                    //dicho archivo(aunque he visto que supuestamente se puede pero no lo e conseguido).
                    Console.WriteLine(messages.mFabricante+a.Maker+messages.mModelo+a.Model);
                    //Console.WriteLine($"Fabricante:{a.Maker}  Modelo:{a.Model}");
                }
            //}
        }

        public static void Ejer7(List<Car> coche)
        {
            var ej7 = coche.Where(x => x.location.Latitude==null && x.location.Longitude==null).Select(j=> new busquedaCoche {Modelo=j.Model,Marca=j.Maker });
            foreach (var a in ej7)
            {
                Console.WriteLine(messages.mFabricante + a.Marca + messages.mModelo + a.Modelo);
            }
        }
    }
}
