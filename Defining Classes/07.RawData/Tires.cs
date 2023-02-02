using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Tires
    {
        private int age;
        private double pressure;

        public Tires(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }

        public int Age { get; set; }
        public double Pressure { get; set; }
    }
}
