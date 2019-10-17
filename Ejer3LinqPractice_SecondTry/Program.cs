using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejer3LinqPractice_SecondTry.Car;

namespace Ejer3LinqPractice_SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = JsonConvert.DeserializeObject<List<Car>>(
                File.ReadAllText("Cars.json"));
        }

        static void Ejer2(List<Car> cars)
        {
            cars.Select(x => x.Maker).Distinct();
        }

        static void Ejer3(List<Car> cars)
        {
            cars.Where(x => string.IsNullOrEmpty(x.Color))
                .Select(x => x.Color).Distinct();
        }

        static void Ejer4(List<Car> cars)
        {
            var modelAndMakers = 
                cars.Where(x => x.Color == "Fuchsia")
                .Select(x =>
                    new ModelAndMaker(x.Model, x.Maker));                
        }

        static void Ejer5(List<Car> cars)
        {
            string lat = Console.ReadLine();
            string longitud = Console.ReadLine();

            double latDouble = 0;
            double longDouble = 0;
            
            double.TryParse(lat, out latDouble);
            double.TryParse(longitud, out longDouble);

            var loc = new Location(latDouble, longDouble);
;
            if(cars.Any(x => x.location.Equals(loc) && 
                        x.Color == "Turquoise"))
            {
                Console.WriteLine("OK");
            }
        }

        static void Ejer6(List<Car> cars)
        {
            cars.Where(x => x.Year > 2000);
        }

        static void Ejer7(List<Car> cars)
        {
            cars.Where(x => x.location.Equals(null))
                .Select(x => new ModelAndMaker(x.Model, x.Maker));               
        }

        static void Ejer8(List<Car> cars)
        {
            cars.Where(x => x.Color == "Blue" && x.Year < 2000);
        }

        static void Ejer9(List<Car> cars)
        {
            cars.GroupBy(x => x.Maker);
        }
        
        static void Ejer10(List<Car> cars)
        {
            var groupMakerks = cars.GroupBy(x => x.Maker);
                                
            foreach(var g in groupMakerks)
            {
                g.Select(x => x.Color).Distinct();
            }
        }

        static void Ejer11(List<Car> cars)
        {

        }

        static void Ejer12(List<Car> cars)
        {
            cars.FirstOrDefault(x => x.Year > 2000 && x.Maker == "Dodge");
        }

        static void Ejer13(List<Car> cars)
        {
            cars.Where(x => x.Year == null);
        }

        static void Ejer14(List<Car> cars)
        {
            var carsByYear = cars.GroupBy(x => x.Year);

            foreach(var carByYear in carsByYear)
            {
                carByYear.Where(x => x.Color == "Blue").Count();
            }
        }

        static void Ejer15(List<Car> cars)
        {
            cars.Where(x => x.Maker == "Hyundai" && x.Year == null && x.Color == null);
        }                
    }

    public static class ExtensionMethods
    {
        static List<Car> Ejer16(this List<Car> cars, string color, int year) =>
            cars.Where(x => !string.IsNullOrEmpty(x.Color) &&
                       x.Year != year)
                        .ToList();
    }
}
