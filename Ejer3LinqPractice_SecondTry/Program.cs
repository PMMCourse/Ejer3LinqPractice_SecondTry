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

        public static void Ejercicio5(List<Coche> listaCoches)
        {
            //DUDA

            /*double latitud, longitud;
            Console.WriteLine("Introduzca una latitud: ");
            Console.ReadLine();
            Console.WriteLine("Introduzca una longitud: ");
            Console.ReadLine();
            */
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
            //¿?¿?¿¿?
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
            //?¿?¿¿?
        }

        public static void Ejercicio12(List<Coche> listaCoches)
        {
            var firstDodge = listaCoches.Where(x => x.Maker == "Dodge" && x.Year < 2000).FirstOrDefault();
            //.Take();
            Console.WriteLine(firstDodge.ToString());

            //Lo tenía con Take, no sé si sería correcto, por eso te pregunté lo del FirstOrDefault.
        }

        public static void Ejercicio13(List<Coche> listaCoches)
        {
            //Sé que se usa el .IsNullOrEmpty pero no sé aplicarlo
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
            //Sé que se usa el .IsNullOrEmpty pero no sé aplicarlo, al igual que en el 13
        }

        public static void Ejercicio16(List<Coche> listaCoches)
        {
            //¿?¿?¿?¿?
        }
    }
}
