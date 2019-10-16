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

         static List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {
        }

        static List<Car> Ejer1()
        {
            using (StreamReader lector = new StreamReader("Cars.json"))
            {
                string json = lector.ReadToEnd();
                List<Car> resultado = JsonConvert.DeserializeObject<List<Car>>(json);
                return resultado;
            }
        }

        public void Ejer2()
        {
             var fabricantes=cars.Select(x => x.Maker).Distinct();
            
            foreach (var i in fabricantes)
                {

                Console.WriteLine($"Los fabricantes son: {i.Maker}");
}

    }

        public void Ejer3()
        {
             var colores=cars.Select(x => x.Color).Distinct();
            
            foreach (var i in colores)
                {

                Console.WriteLine($"Los diferentes colores son: {i.Color}");
}

    }


        public void Ejer4()
            {


             var cochefuc=cars.Where(x => x.Color == "Fuscia");

            foreach(var i in cochefuc)
            {
                Console.WriteLine($"Fabricante: {i.Maker}, Modelo: {i.Model}");
            }

}
        
        public void Ejer5()
            {

            double Latitude = 0;
            double Longitude = 0;

             Console.WriteLine("Escribe una latitud");
            Latitude = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe una longitud");
            Longitude = double.Parse(Console.ReadLine());

            var car_result = cars.Where(x => x.Location.Latitude == Latitude && x.Location.Longitude == Longitude && x.Color == "Turquoise");
            foreach(var i in car_result)
            {
                Console.WriteLine($"Con estos datos: {i.Model}");
               
            }

}

        public void Ejer6()
            {

            var listCarYear = cars.Where(x => x.Year > 2000);

            foreach(var i in listCarYear)
                {
                Console.WriteLine($"Modelo: {i.Model}");
}



            }

        public void Ejer7()
            {


}

        public void Ejer8()
            {

            var listCar = cars.Where(x => x.Color == "Blue" && x.Year < 2000);

            foreach(var i in listCar)
                {
                Console.WriteLine($"Modelos de coche azules y anteriores al 2000: {i.Model}");
}
}

        public void Ejer9()
        {

            var carsAgrup = cars.GroupBy(x => x.Maker);

            foreach (var i in carsAgrup)
            {
                Console.WriteLine($"Fabricante: {i.Key}");

                foreach (var j in i)
                {
                    Console.WriteLine($"Modelo: {j.Model}");
                }
            }
        }


        public void Ejer10()
            {

            var carsAgrup = cars.GroupBy(x => x.Maker);

            foreach (var i in carsAgrup)
            {
                Console.WriteLine($"Fabricante: {i.Key}");

                foreach (var j in i)
                {
                    Console.WriteLine($"Modelo: {j.Model}");
                }
            }

            var colores=cars.Select(x => x.Color).Distinct();
            
            foreach (var i in colores)
                {

                Console.WriteLine($"Los diferentes colores son: {i.Color}");


}
            }

        public void Ejer11()
            {
}

        public void Ejer12()
            {

            var firstCar = cars.FirstOrDefault(x => x.Maker == "Dodge" && x.Year > 2000);
            Console.WriteLine(firstCar.Model);
}

        public void Ejer13()
            {

            var listCar = cars.Where(x => String.IsNullOrWhiteSpace(x.Year));

            foreach(var i in listCar)
            {
                Console.WriteLine(i.Model);
            }


}


        public void Ejer14()
            {

            var listCar = cars.GroupBy(x => x.Year);
            var cantColorB = cars.Count(y => y.Color == "Blue");

            foreach (var i in listCar)
            {

                Console.WriteLine($"Año: {i.Year}");

                foreach (var j in i)
                {

                    Console.WriteLine($"Modelo: {j.Model}");
                }
            }
             if (cantColorB != null)
            {
                Console.WriteLine($"Cantidad de coches de color azul: {cantColorB}");
                
            }
}


        public void Ejer15()
            {

            var listCar = cars.Where(x => x.Maker == "Hyundai" && String.IsNullOrWhiteSpace(x.Year) && String.IsNullOrWhiteSpace(x.Color));

            foreach(var i in listCar)
                {

                Console.WriteLine($"Modelo/s Hyundai sin año ni color: {i.Model}");
}
}

        public void Ejer16()
{

}









}}




