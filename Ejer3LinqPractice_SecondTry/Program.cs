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
            Ejer6();
        }

        static List<Cars> Ejer1()
        {
            using (StreamReader lector = new StreamReader("Cars.json"))
            {
                string json = lector.ReadToEnd();
                List<Cars> listaCoche = JsonConvert.DeserializeObject<List<Cars>>(json);
                return listaCoche;
            }
        }
        static void Ejer2() 
        {
            var fabricantes = listaCoche.GroupBy(x => x.Maker).Select(y => y.First());
            foreach (var item in fabricantes)
            {
                Console.WriteLine(item.Maker);
            }
        } 

        
        static void Ejer3() 
        {
            var colores = listaCoche.GroupBy(x => x.Color).Select(y => y.First());
            foreach (var item in colores)
            {
                Console.WriteLine(item.Color);
            }
        }

        static void Ejer4()
        {
            var colorfucsia = listaCoche.Where(x => x.Color=="Fuscia");

            foreach (var item in colorfucsia)
	        {
                Console.WriteLine($"Fabricante: {item.Maker}, Modelo{item.Model}, Color{item.Color}");
	        }
        }

        static void Ejer6() 
        {
            var coches2000 =listaCoche.Where(x => x.Year>2000 );
            
            foreach (var item in coches2000)
            {
                Console.WriteLine($"Los coches con un año superior al 2000 son: {item.Maker},{item.Model} ");
            }
            
        }

        static void Ejer8()
        {
            var cochesazul = listaCoche.Where(x => x.Color == "Blue" && x.Year<2000 );
            
            foreach (var item in cochesazul)
            {
                Console.WriteLine($"Los coches azules y año <2000: {item.Maker},{item.Model} ");
            }
        }

        static void Ejer9()
        {
            var cochesfab = listaCoche.GroupBy(x =>x.Maker);
            foreach(var i in cochesfab)
            {
                Console.WriteLine(i.Key);
                foreach (var j in i)
	            {
                    Console.WriteLine(j.Maker);
	            }
            }
        }
        static void Ejer11()
        {
        
            for (int i = 0; i < listaCoche.Count; i += 20)
            {
                var coche20en20 = listaCoche.Skip(0 + i).Take(20);
                foreach (var item in coche20en20)
                {
                    Console.WriteLine(item.Maker);
                }
                Console.ReadKey();

            }
        
        }

        static void Ejer12()
        {
            var cochedodge = listaCoche.Where(x => x.Maker == "Dodge" && x.Year>2000).Select(x => x.First());

                Console.WriteLine(cochedodge);
  
        }

        static void Ejer13()
        {
            var cocheanionull = listaCoche.Where(x => x.Year== 0);
                
                foreach (var item in cocheanionull)
	            {
                    Console.WriteLine($"Fabricante: {item.Maker}\n Modelo: {item.Model}\n Año: {item.year}");
	            }
        }

        static void Ejer14()
        {
            var todoscoches = listaCoche.GroupBy(x => x.Year).Count(x =>x.Color == "Blue");
                foreach (var item in collection)
	            {
                //no se como mostrar muchos coches y el contador
                    Console.WriteLine();
	            }
        }

        static void Ejer15()
        {
            var cochehyundai = listaCoche.Where(x =>x.Maker == "Hyundai" && x.Year == 0 && x.Color== "Null");

            foreach (var item in cochehyundai)
	        {
                Console.WriteLine($"Fabricante: {item.Maker}\nAño: {item.Year}\nColor:{item.Color}");
	        }
        }
    }
}
