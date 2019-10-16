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
        static List<Cars> listaCoche = new List<Cars>();
        static void Main(string[] args)
        {
            Ejer11();
        }

        static List<Cars> Ejer1()
        {
            using (StreamReader lector = new StreamReader("Cars.json"))
            {
                string json = lector.ReadToEnd();
                List<Cars> resultado = JsonConvert.DeserializeObject<List<Cars>>(json);
                return resultado;
            }
        }

        static void Ejer2() //Muestra los distintos Fabricantes, sin duplicar ningún fabricante.
        {
            var dist = listaCoche.GroupBy(x => x.Maker).Select(y => y.First());
            foreach (var i in dist)
            {
                Console.WriteLine(i.Maker);
            }
        }

        static void Ejer3() //Muestra los diferentes colores sin duplicar ningún color.
        {
            var color = listaCoche.GroupBy(x => x.Color).Select(y => y.First());
            foreach (var i in color)
            {
                Console.WriteLine(i.Color);
            }
        }

        static void Ejer4() //Muestra fabricante y modelo. Del color Fuscia.
        {
            var fucksia = listaCoche.Where(x => x.Color == "Fuscia");
            foreach (var i in fucksia)
            {
                Console.WriteLine("Frabricante :" + i.Maker + "Modelo :" + i.Model);
            }
        }

        static void Ejer5(double latitud, double longitud) //Permite al usuario introducir una latitud y una longitud. Indica al usuario si encuentra un coche de color Turquoise dentro de esa latitud y longitud facilitada.
        {
            var buscar = listaCoche.Where(x => x.Latitude == latitud && x.Longitude == longitud);
            foreach (var i in buscar)
            {
                if (i.Color == "Turquoise")
                {
                    Console.WriteLine("Hay un coche color Turquoise");
                }
                else
                {
                    Console.WriteLine("No hay un coche color Turquoise");
                }
            }

        }

        static void Ejer6() //Muestra todos los coches del año posterior de 2000.
        {
            var edad = listaCoche.Where(x => int.Parse(x.Year) >= 2000);
            foreach (var i in edad)
            {
                Console.WriteLine(i.Maker + " - " + i.Model);
            }
        }

        static void Ejer7() //Genera una nueva clase con modelo y fabricante. Muestra todos los coches que no tengan latitud, ni longitud Convierte en la búsqueda a esa clase.
        {
            //No la entiendo
        }

        static void Ejer8() //Busca todos los coches de color Blue y que sean anteriores al año 2000.
        {
            var e = listaCoche.Where(x => int.Parse(x.Year) >= 2000 && x.Color == "Blue");
            foreach (var i in e)
            {
                Console.WriteLine(i);
            }
        }
        
        static void Ejer9() //Agrupa todos los coches por fabricante, muestralos por pantalla.
        {
            var rav = listaCoche.GroupBy(x => x.Maker);
            foreach (var i in rav)
            {
                Console.WriteLine(i.Key);
                foreach (var e in i)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Ejer10() //Agrupa todos los coches por fabricante, muestra los colores disponibles sin duplicar la muestra.
        {
            var fabcolor = listaCoche.GroupBy(x => x.Maker).Select(y => y.First());
            foreach (var i in fabcolor)
            {
                Console.WriteLine(i.Maker + " - " + i.Color);
            }
        }

        static void Ejer11() //Página de 20 en 20 pulsando una tecla y muestra todos los coches disponibles
        {
            for (int i = 0; i < listaCoche.Count; i += 10)
            {
                var lista = listaCoche.Skip(0 + i).Take(20).Select(y => y.id);
                foreach (var x in lista)
                {
                    Console.WriteLine(x);
                }
                Console.ReadKey();

            }
        }

        static void Ejer12() //Encuentra el primer coche posterior del año 2000 del fabricante Dodge
        {
            var dodge = listaCoche.Where(x => x.Maker == "Dodge" && int.Parse(x.Year) > 2000).Take(1);
            foreach (var i in dodge)
            {
                Console.WriteLine(i);
            }
        }

        static void Ejer13() //Muestra todos los coches que no tengan guardado el año.
        {
            var ok = listaCoche.Where(x => string.IsNullOrEmpty(x.Year));
            foreach (var i in ok)
            {
                Console.WriteLine(i);
            }
        }

        static void Ejer14() //Agrupa por año todos los coches y muestra la cantidad que hay de color Azul
        {
            var col = listaCoche.Where(x => x.Color == "Blue").GroupBy(y => y.Year);
            foreach (var i in col)
            {
                Console.WriteLine(i);
            }
        }

        static void Ejer15() //Busca todos los coches Hyundai que no tengan ni año, ni color.
        {
            var bar = listaCoche.Where(x => x.Maker == "Hyundai" && string.IsNullOrEmpty(x.Year) && string.IsNullOrEmpty(x.Color));
            foreach (var i in bar)
            {
                Console.WriteLine(i);
            }
        }

        static void Ejer16() //Crea un método de extensión donde se pueda introducir color y año, devolviendo el listado de Coches que no cumplan la condición.
        {
        }

        public static class ExtensionMethods
        {
            public static void listVehiculos<T>(string color, string ano)
            {
                var lv = listaCoche.Where(x => x.Year != ano && x.Color != color);
                foreach (var i in lv)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}