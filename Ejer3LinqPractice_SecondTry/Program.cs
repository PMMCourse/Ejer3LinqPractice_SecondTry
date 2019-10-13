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
        static List<Car> coches;
        static void Main(string[] args)
        {
            Ejer1();
            Ejer7(coches);
            coches.Ejer16(2000, "Blue");
        }
        static void  Ejer1()
        {
            string archivo = File.ReadAllText("Cars.json");
            coches = JsonConvert.DeserializeObject<List<Car>>(archivo);
        }
        static void Ejer2(List<Car> coches)//Lo intente con distincBy pero no reconocia la libreria MoreLinq
        {
            List<Car> marcas = coches.GroupBy(c => c.Maker).Select(x => x.First()).ToList();
            foreach (var i in marcas)
            {
                Console.WriteLine(i.Maker);
            }
        }
        static void Ejer3(List<Car> coches)
        {
            List<Car> colores = coches.GroupBy(c => c.Color).Select(x => x.First()).ToList();
            foreach (var i in colores)
            {
                Console.WriteLine(i.Color);
            }

        }
        static void Ejer4(List<Car> coches)
        {
            var listaFabri = coches.Where(x => x.Color == "Fuscia");
            foreach (var i in listaFabri)
            {
                Console.WriteLine($"Fabricante: {i.Maker}, Modelo: {i.Model}");
            }
        }
        static void Ejer5(List<Car> coches)
        {

            Console.WriteLine("Escribe una latitud");
            double lati = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe una longitud");
            double longi = double.Parse(Console.ReadLine());

            var color = coches.Where(x => x.location.Latitude == lati && x.location.Longitude == longi &&
            x.Color == "Turquoise");
            foreach(var i in color)
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine("Encontrado");
                return;
            }
            Console.WriteLine("No encontrado");
            Console.ReadKey();
        }
        static void Ejer6(List<Car> coches)
        {
            var listaco = coches.Where(x => x.Year > 2000);
            foreach (var i in listaco)
            {
                Console.WriteLine(i.ToString());
            }
        }

        static void Ejer7(List<Car> coches)
        {
            var nuevaclase = coches.Where(x => String.IsNullOrEmpty(x.location.Latitude.ToString()) &&
            String.IsNullOrEmpty(x.location.Longitude.ToString())).Select(y => 
            new ModelFabri { Model = y.Model, Maker = y.Maker }); ;
            foreach (var i in nuevaclase) 
            {
                Console.WriteLine($"Maker: {i.Maker}, Modelo: {i.Model} ");
            }
            
        }
        static void Ejer8(List<Car> coches)
        {
            var listaco = coches.Where(x => x.Year < 2000 && x.Color == "Blue");
            foreach (var i in listaco)
            {
                Console.WriteLine(i.ToString());
            }
        }
        static void Ejer9(List<Car> coches)
        {
            var listaco = coches.GroupBy(x => x.Maker);
            foreach (var x in listaco)
            {
                foreach (var i in x)
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        static void Ejer10(List<Car> coches)
        {
            Ejer9(coches);
            Ejer3(coches);
        }
        static void Ejer11(List<Car> coches)
        {
            for (int i = 0; i < coches.Count; i += 20)
            {
                var lista = coches.Skip(0 + i).Take(20);

                foreach (var x in lista)
                {
                    Console.WriteLine(x.ToString());
                }
                Console.ReadKey();
                Console.WriteLine();
            }
        }
        static void Ejer12(List<Car> coches)
        {
            var listaco = coches.Where(x => x.Year < 2000 && x.Maker == "Dodge").FirstOrDefault();
            
                Console.WriteLine(listaco.ToString());         
        }
    }
    public class ModelFabri: Car
    {
    }
    public static class Extension
    {
        public static void Ejer16(this List<Car> coches, int anio, string color)
        {
            var buscar = coches.Where(x => x.Year != anio && x.Color != color);
            foreach (var i in buscar)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
