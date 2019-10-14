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
         7.- Genera una nueva clase con modelo y fabricante. Muestra todos los coches que no tengan latitud ni longitud Convierte en la búsqueda a esa clase.
        10.- Agrupa todos los coches por fabricante, muestra los colores disponibles sin duplicar la muestra.
         */

            public static List<Cars> coches;
            public static List<Cars> lista()
        {
            String ruta = Path.GetFullPath("Cars.json");//Obtengo de la ruta relativa la absoluta
            StreamReader jsonStream = File.OpenText(ruta);
            var json = jsonStream.ReadToEnd();
            //lo decodifico del formato JSON y lo guardo en una lista de heroes
             coches = JsonConvert.DeserializeObject<List<Cars>>(json);
            return coches;
        }

        public static void EJer4(List<Cars> coches)
        {
            var lista = coches.Where(x=> x.Color == "Fuscia");
            foreach (var i in lista)
            {
                Console.WriteLine($"Fabricante: {i.Maker} Modelo: {i.Model}");
            }
            Console.ReadKey();
        }

        public static void EJer5(List<Cars> coches)
        {
         // Datos de muestra que dan como resultado turquesa, pero solo si los introduzco en la consulta
         //de linq directamente desde el codigo, de la manera en la que lo tengo puesto no comprendo porque la lista en ejecución se queda nula
         //a la hora de recibir las variables de longitud y latitud.
         //Latitude":52.1894953
         //"Longitude":5.3961917

            double latitud=0, longitud=0;
            bool valido=true;
            do
            {
                try
            {
                Console.WriteLine("Introduzca la latitud: ");
                latitud = Double.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca la longitud: ");
                longitud = Double.Parse(Console.ReadLine());
                    valido = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("\n ** Ese dato no es valido** \n");
                valido = false;
            }
            } while (valido == false);

            var lista = coches.Where(x => x.location.Latitude == latitud && x.location.Longitude == longitud);
            foreach (var i in lista)
            {
                if (i.Color.Equals("Turquoise"))
                {
                    Console.WriteLine($"El color asociado es: {i.Color} ");
                }
                else
                {
                    Console.WriteLine("Los datos introducidos no estan asociados a ningun color turquesa");
                }
                
            }
           // Console.ReadKey();
        }
        public static void EJer7(List<Cars> coches)
        {//no me acuerdo como era la otra manera
            List<CarsEJ7> listaCocheEJ7 = (List<CarsEJ7>) coches.Where(x => x.location.Latitude == 0 && x.location.Longitude == 0); 
            foreach (var i in listaCocheEJ7)
            {
                Console.WriteLine($"Coches: {i.Model}");
            }
        }
        public static void EJer10(List<Cars> coches)
        {
            //Me siguen saliendo duplicados aunque especifique que no se repitan
            var lista = coches.GroupBy(x => x.Maker).Distinct();
             var lista2 = coches.GroupBy(x => x.Color).Distinct();

            Console.WriteLine("*** Fabricantes ***");
            Console.WriteLine(" ");
            foreach (var i in lista)
            {
                foreach (var j in i)
                {
                    Console.WriteLine($" Fabricantes: {j.Maker}");
                }

            }
            Console.WriteLine("*** Colores ***");
            Console.WriteLine(" ");
            foreach (var i in lista2)
            {
                foreach (var j in i)
                {
                    Console.WriteLine($" Colores disponibles: {j.Color}");
                }

            }

        }
        static void Main(string[] args)
        {
            lista();//carga la lista
            //EJer4(coches);//Ok
            //EJer5(coches);//Ok
            //EJer7(coches);//No me va, aparte de que no me acuerdo como se hizo en clase el ejercicio parecido del boletin anterior 
            //EJer10(coches);//Me siguen saliendo duplicados aunque especifique que no se repitan
        }
    }
}
