using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        private string name;
        private string type;
        private double rate;
        private int days;

        public Renovator(string name, string type, double rate, int days)
        {
            Name = name;
            Type = type;
            Rate = rate;
            Days = days;
        }

        public string Name { get; private set; }
        public string Type { get; private set; }
        public double Rate { get; private set; }
        public int Days { get; private set; }
        public bool Hired { get; set; } = false;
        public bool Paid { get; set; } = false;

        public override string ToString()
        {
            return $"-Renovator: {Name}{Environment.NewLine}" +
                   $"--Specialty: {Type}{Environment.NewLine}" +
                   $"--Rate per day: {Rate} BGN";
        }
    }
}
