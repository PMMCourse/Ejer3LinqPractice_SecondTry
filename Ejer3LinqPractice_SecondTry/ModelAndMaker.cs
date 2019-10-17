using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice_SecondTry
{
    public class ModelAndMaker
    {
        public ModelAndMaker(string model, string maker)
        {
            Maker = maker;
            Model = model;
        }

        public string Maker { get; set; }

        public string Model { get; set; }

        public override string ToString()
            => $"{Maker} and {Model}";
        
    }
}
