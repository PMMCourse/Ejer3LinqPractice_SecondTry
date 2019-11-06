using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ejer3LinqPractice_SecondTry
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Ejercicio1
            string documentoCars = File.ReadAllText("Cars.json");
            JsonConvert.DeserializeObject<List<Coche>>(documentoCars);
            

        }

        public static void Ejercicio2(List<Coche> listaCoches)
        {
            var mostrarFabr = listaCoches.GroupBy(x => x.Maker).Select(y => y.FirstOrDefault());

            foreach (var a in mostrarFabr)
            {
                Console.WriteLine(a.Maker);
            }
        }

        public static void Ejercicio3(List<Coche> listaCoches)
        {
            var mostrarColors = listaCoches.GroupBy(x => x.Color).Select(y => y.FirstOrDefault());

            foreach (var a in mostrarColors)
            {
                Console.WriteLine(a.Color);
            }
        }
        public static void Ejercicio4(List<Coche> listaCoches)
        {
            var MostrarFM = listaCoches.Where(x => x.Color == "Fuscia");

            foreach (var a in MostrarFM)
            {
                Console.WriteLine($"Fabricante:, {a.Maker}, Modelo:, {a.Model}");
                // ("Fabricante:" + a.Maker + "Modelo:" + a.Model);

                //Creo que la mejor manera de concatenar en C# es con el dólar, pero tampoco estoy seguro
            }
        }

        public static void Ejercicio5(List<Coche> listaCoches, double latitud, double longitud)
        {
            var cocheTQ = listaCoches.Where(x => x.Latitude == latitud && x.Longitude == longitud);
            foreach (var a in cocheTQ)
            {
                if (a.Color == "Turquise")
                {
                    Console.WriteLine("Bien");
                }
                else
                {
                    Console.WriteLine("No hay un coche de ese color", "ERROR");
                }
            }
        }
        public static void Ejercicio6(List<Coche> listaCoches)
        {
            //var  = listaCoches.Where(x => x.Year)
            var AgruparColores = listaCoches.Where(x => x.Year > 2000);

            foreach (var a in AgruparColores)
            {
                Console.WriteLine(a.ToString());
            }
        }

        public static void Ejercicio7(List<Coche> listaCoches)
        {
            var crearClase = listaCoches.Where(x => String.IsNullOrEmpty(x.Latitude.ToString()) 
            && String.IsNullOrEmpty(x.Longitude.ToString())).Select(y =>
            new ModeloFabricante { Model = y.Model, Maker = y.Maker });;

            foreach (var a in crearClase)
            {
                Console.WriteLine("The maker"+ a.Maker + "the model"+ a.Model);
            }
        }

        public static void Ejercicio8(List<Coche> listaCoches)
        {
            // var 
            var carsBlue = listaCoches.Where(x => x.Year < 2000 && x.Color == "Blue");

            foreach (var a in carsBlue)
            {
                Console.WriteLine(a.ToString());
            }

        }
        public static void Ejercicio9(List<Coche> listaCoches)
        {
            var cochesPorF = listaCoches.GroupBy(x => x.Maker);

            foreach (var x in cochesPorF)
            {
                foreach (var a in x)
                {
                    Console.WriteLine(a.ToString());
                }
            }
        }

        public static void Ejercicio10(List<Coche> listaCoches)
        {
            var cochesPorFC = listaCoches.GroupBy(x => x.Maker).Select(y => y.FirstOrDefault());

            foreach (var a in cochesPorFC)
            {
                Console.WriteLine($"Fabricante: , {a.Maker}, Color: , {a.Color}");
            }

            //Creo que podría haber reutilizado el ejercicio 9, como comentaste en la clase anterior que podíamos hacer.
        }
        public static void Ejercicio11(List<Coche> listaCoches)
        {
            for (int i = 0; i < listaCoches.Count; i += 20)
            {
                var lista = listaCoches.Skip(0 + i).Take(20);

                foreach (var x in lista)
                {
                    Console.WriteLine(x.ToString());
                }
                Console.ReadKey();
                Console.WriteLine();
            }
        }
        public static void Ejercicio12(List<Coche> listaCoches)
        {
            var firstDodge = listaCoches.Where(x => x.Maker == "Dodge" && x.Year < 2000).FirstOrDefault();
            //.Take();
            Console.WriteLine(firstDodge.ToString());

            //Lo tenía con Take, no sé si sería correcto, por eso te pregunté lo del FirstOrDefault.
        }
        public static void Ejercicio14(List<Coche> listaCoches)
        {
            var agruparCochesBlue = listaCoches.Where(x => x.Color == "Blue").GroupBy(y => y.Year);

            foreach (var a in agruparCochesBlue)
            {
                Console.WriteLine(a.ToString());
            }
        }

        public static void Ejercicio15(List<Coche> listaCoches)
        {
            var bar = listaCoches.Where(x => x.Maker == "Hyundai" && string.IsNullOrEmpty(x.Year.ToString()) && string.IsNullOrEmpty(x.Color));
            foreach (var a in bar)
            {
                Console.WriteLine(a);
            }
        }
            public static void Ejercicio16(List<Coche> listaCoches, int anio, string color)
            {
                var buscar = listaCoches.Where(x => x.Year != anio && x.Color != color);
                foreach (var i in buscar)
                {
                    Console.WriteLine(i.ToString());

                }
            }

        private class ModeloFabricante
        {
            public string Model { get; set; }
            public string Maker { get; set; }
        }
    }
}






    


    

