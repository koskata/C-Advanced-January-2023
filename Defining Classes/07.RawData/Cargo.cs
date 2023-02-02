using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Cargo
    {
        private string type;
        private double weight;

        public Cargo(double weight, string type)
        {
            
            Weight = weight;
            Type = type;
        }

        public string Type { get; set; }
        public double Weight { get; set; }
    }
}
